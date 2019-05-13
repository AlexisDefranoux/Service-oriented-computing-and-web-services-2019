using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Device.Location;
using VelibGuiClient.VelibService;
using System.Threading.Tasks;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        string originAddress;
        string destinationAddress;

        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Attributes.Add("onclick", "onclick()");
            initCities();
        }

        private async void initCities()
        {
            ServiceClient serviceClient = new ServiceClient();
            Task<City[]> asyncResponse = serviceClient.GetCitiesAsync();
            City[] cities = await asyncResponse;
            ville.Items.Clear();
            foreach (City city in cities)
            {
                ville.Items.Add(city.name);
            }
            ville.SelectedValue = "marseille";
        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            //récuperer les latitudes et longitudes de départ et arrivé.
            originAddress = inputStart.Value;
            destinationAddress = inputEnd.Value;
            Position originPosition = getLatLng(originAddress);
            Position destinationPosition = getLatLng(destinationAddress);

            Task<Station> nearestStationOriginTask = getStation(originPosition, true);
            Station nearestStationOrigin = await nearestStationOriginTask;
            Task<Station> nearestStationDestinationTask = getStation(destinationPosition, false);
            Station nearestStationDestination = await nearestStationDestinationTask;

            string requestPage = "Contact?" +
                                "originAddress=" + HttpUtility.UrlEncode(originAddress) +
                                "&destinationAddress=" + HttpUtility.UrlEncode(destinationAddress) +
                                "&originNearestStation=" + HttpUtility.UrlEncode(nearestStationOrigin.address) +
                                "&destinationNearestStation=" + HttpUtility.UrlEncode(nearestStationDestination.address);
            Response.Redirect(requestPage, false);
        }

        private async Task<Station> getStation(Position position, bool start)
        {
            String maVille = ville.SelectedValue;
            ServiceClient serviceClient = new ServiceClient();
            Task<Station> asyncResponse = serviceClient.GetNeerestStationAsync(maVille, position, start);
            Station station = await asyncResponse;
            return station;
        }

        private string restRequest(String url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return responseFromServer;
        }

        private Position getLatLng(string Address)
        {
            string url2 = "https://maps.google.com/maps/api/geocode/json?address=" + Address + "&key=AIzaSyAG6cBbOp7_ko1vu350eqXRrJR47MGIo7w";
            WebRequest request = WebRequest.Create(url2);
            string Lat = "";
            string Lng = "";
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var jsonResponse = JObject.Parse(reader.ReadToEnd()); // do something fun...

                    JArray a = JArray.Parse(jsonResponse["results"].ToString());
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Lat = o["geometry"]["location"]["lat"].ToString();
                        Lng = o["geometry"]["location"]["lng"].ToString();
                    }
                }
            }
            return new Position()
            {
                lat = double.Parse(Lat),
                lng = double.Parse(Lng)
            };
        }
    }
}