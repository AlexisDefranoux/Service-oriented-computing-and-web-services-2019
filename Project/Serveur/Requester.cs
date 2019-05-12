using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serveur
{
    abstract class Requester<T> : ICacheFeeder<T>
    {
        protected String uriP;
        protected String key;

        public Requester(String uriPart, String key)
        {
            this.uriP = uriPart;
            this.key = key;
        }

        public abstract T GetResource(string name);

        protected string restRequest(String url)  
        {
            try
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
            } catch (Exception e)
            {
                return "";
            }
            
        }
    }
}
