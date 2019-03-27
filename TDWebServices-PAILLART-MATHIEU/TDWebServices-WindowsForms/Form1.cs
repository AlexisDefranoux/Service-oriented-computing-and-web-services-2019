using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TDWebServices_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelVille_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonGetStations_Click(object sender, EventArgs e)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract="+textboxVille.Text+"&apiKey=09d937f07cdc888619900a607091ce3d0a7d062d");
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            Console.WriteLine(textboxVille.Text);
            WebResponse response = request.GetResponse();
            // Display the status.
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            var data =(JArray)JsonConvert.DeserializeObject(responseFromServer);
            string adress=""; 
            for(int i = 0; i < data.Count; i++)
            {
                adress+= "\n" + data[i]["address"].Value<string>() +"\r\n";
                adress += "-----------------------\r\n";
            }
            Console.WriteLine(responseFromServer);
            // Display the content.
            textboxStations.Text = adress;
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        }

        private void textboxVille_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) //13 = enter (magic number key)
            { 
                buttonGetStations_Click(sender, e);
            }
        }
    }
}
