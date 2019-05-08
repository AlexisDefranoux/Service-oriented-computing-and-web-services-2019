using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        List<Station> stations;
        List<City> cities;
        String apiKey = "&apiKey=7e929541306799d5f756f49451bc935fa6cf1d09";
        String url = "https://api.jcdecaux.com/vls/v1/";

        protected void Page_Load(object sender, EventArgs e)
        {
            cities = JsonConvert.DeserializeObject<List<City>>(restRequest(url + "contracts?" + apiKey));
            ville.Items.Clear();
            foreach (City city in cities)
            {
                ville.Items.Add(city.name);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string maVille = inputStart.Value;
            stations = JsonConvert.DeserializeObject<List<Station>>(restRequest(url + "stations?contract=" + maVille + apiKey));
            cbStation.Items.Clear();
            foreach (Station station in stations)
            {
                cbStation.Items.Add(station.name);
            }
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