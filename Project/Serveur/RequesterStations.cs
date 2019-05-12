using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Serveur
{
    class RequesterStations : Requester<List<Station>>
    {
        public RequesterStations(string uriPart, string key) : base(uriPart, key)
        {
        }

        public override List<Station> GetResource(string name)
        {
            string url = this.uriP + "?" + "contract="+ name + "&" + this.key;
            string res = this.restRequest(url);
            return JsonConvert.DeserializeObject<List<Station>>(res);
        }
    }
}
