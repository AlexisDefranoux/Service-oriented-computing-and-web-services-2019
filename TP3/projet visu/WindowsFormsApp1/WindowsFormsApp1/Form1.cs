using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<JsonResult> result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            string maVille = txtbVille.Text;
            string reponse = getBike(maVille);
            result = JsonConvert.DeserializeObject<List<JsonResult>>(reponse);
            tabBike.DataSource = result;
            cbStation.Items.Clear();

            foreach (JsonResult json in result){
                cbStation.Items.Add(json.name);
            }

            lblStation.Visible = true;
            cbStation.Visible = true;
        }

        private string getBike(string maVille)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
            "https://api.jcdecaux.com/vls/v1/stations?contract="+maVille+"&apiKey=7e929541306799d5f756f49451bc935fa6cf1d09");
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            return responseFromServer;
        }

        private void cbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbStation.GetItemText(this.cbStation.SelectedItem);
            foreach (JsonResult json in result)
            {
                if (selected.Equals(json.name))
                {
                    lblNomInfo.Text = json.name;
                    groupBox1.Visible = true;
                    return;
                }
            }
        }
    }

    internal class JsonResult
    {
            public int number { get; set; }
            public string contract_name { get; set; }
            public string name { get; set; }
            public string address { get; set; }

    }
}
