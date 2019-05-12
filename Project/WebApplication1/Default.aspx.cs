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
using WebApplication1.model;
using System.Device.Location;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        List<Station> stations;
        List<City> cities;
        String apiKey = "&apiKey=7e929541306799d5f756f49451bc935fa6cf1d09";
        String url = "https://api.jcdecaux.com/vls/v1/";
        string originAddress;
        string destinationAddress;


        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Attributes.Add("onclick", "onclick()");
            cities = JsonConvert.DeserializeObject<List<City>>(restRequest(url + "contracts?" + apiKey));
            if (!IsPostBack)
            {
                ville.Items.Clear();
                foreach (City city in cities)
                {
                    ville.Items.Add(city.name);
                }
                ville.SelectedValue = "marseille";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string maVille = ville.SelectedValue;
            stations = JsonConvert.DeserializeObject<List<Station>>(restRequest(url + "stations?contract=" + maVille + apiKey));

            //récuperer les latitudes et longitudes de départ et arrivé.
            originAddress = inputStart.Value;
            destinationAddress = inputEnd.Value;
            Position originPosition = getLatLng(originAddress);

            Position destinationPosition = getLatLng(destinationAddress);
            System.Diagnostics.Debug.WriteLine("OriginLat :"+ originPosition.lat);
            System.Diagnostics.Debug.WriteLine("OriginLng :"+ originPosition.lng);
            System.Diagnostics.Debug.WriteLine("DestinationLat :"+ destinationPosition.lat);
            System.Diagnostics.Debug.WriteLine("DestinationLng :"+ destinationPosition.lng);

            Station nearestStationOrigin = getNearestStation(maVille, originPosition);
            Station nearestStationDestination = getNearestStation(maVille, destinationPosition);
            System.Diagnostics.Debug.WriteLine("originStation :" + nearestStationOrigin);
            System.Diagnostics.Debug.WriteLine("destinationStation :" + nearestStationDestination);


            string requestPage = "Contact?" +
                                "originAddress=" + HttpUtility.UrlEncode(originAddress) +
                                "&destinationAddress=" + HttpUtility.UrlEncode(destinationAddress) +
                                "&originNearestStation=" + HttpUtility.UrlEncode(nearestStationOrigin.address) +
                                "&destinationNearestStation=" + HttpUtility.UrlEncode(nearestStationDestination.address);
            Response.Redirect(requestPage);
        }

        private string restRequest(String url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);
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

        private Station getNearestStation(string Ville, Position position)
        {
            var coord = new GeoCoordinate(position.lat, position.lng);
            var nearest = stations.Select(x => new GeoCoordinate(x.position.lat, x.position.lng))
                                   .OrderBy(x => x.GetDistanceTo(coord))
                                   .First();

            Position nearestStation = new Position()
            {
                lat = nearest.Latitude,
                lng = nearest.Longitude
            };
            return getStation(stations, nearestStation);
        }

        private Station getStation(List<Station> stations,Position position)
        {
            return stations.FirstOrDefault(x => x.position.Equals(position));
        }
    }
}