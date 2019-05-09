using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using GoogleMaps.LocationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            ville.Items.Clear();
            foreach (City city in cities)
            {
                ville.Items.Add(city.name);
            }

        }
    
        protected void Button1_Click(object sender, EventArgs e)
        {
            string maVille = ville.SelectedItem.Value;
            stations = JsonConvert.DeserializeObject<List<Station>>(restRequest(url + "stations?contract=" + maVille + apiKey));

            //récuperer les GPS de dep et arr
            originAddress = inputStart.Value;
            destinationAddress = inputEnd.Value;
        //comparer les distance de dep et arr
            string url1 = "https://maps.google.com/maps/api/geocode/json?address=" + originAddress + "&key=AIzaSyAG6cBbOp7_ko1vu350eqXRrJR47MGIo7w";
            WebRequest request = WebRequest.Create(url1);
            string originLat="";
            string originLng="";
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var jsonResponse = JObject.Parse(reader.ReadToEnd()); // do something fun...

                    JArray a = JArray.Parse(jsonResponse["results"].ToString());

                    foreach (JObject o in a.Children<JObject>())
                    {
                        originLat = o["geometry"]["location"]["lat"].ToString();
                        originLng = o["geometry"]["location"]["lng"].ToString();
                    }

                }


            }
            string url2 = "https://maps.google.com/maps/api/geocode/json?address=" + destinationAddress  + "&key=AIzaSyAG6cBbOp7_ko1vu350eqXRrJR47MGIo7w";
            WebRequest requestDestination = WebRequest.Create(url2);
            string destinationLat="";
            string destinationLng="";
            using (WebResponse response = (HttpWebResponse)requestDestination.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var jsonResponse = JObject.Parse(reader.ReadToEnd()); // do something fun...

                    JArray a = JArray.Parse(jsonResponse["results"].ToString());

                    foreach (JObject o in a.Children<JObject>())
                    {
                        destinationLat = o["geometry"]["location"]["lat"].ToString();
                        destinationLng = o["geometry"]["location"]["lng"].ToString();
                    }

                }


            }
            string url3 = "Contact?" +
"originAddress=" + HttpUtility.UrlEncode(originAddress)+
"&destinationAddress=" + HttpUtility.UrlEncode(destinationAddress) ;
            Response.Redirect(url3);
            Thread.Sleep(1000);
            //PLUS QUE L'AJOUT DES VELIBS ET C'EST BON AAHAHAAH
            //set les 4 adresses sur la map

            /*

            cbStation.Items.Clear();
            foreach (Station station in stations)
            {
                cbStation.Items.Add(station.position.lat.ToString());
            }*/
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
    }
}