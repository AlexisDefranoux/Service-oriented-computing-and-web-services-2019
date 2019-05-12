using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Serveur
{
    class RequesterCity : Requester<List<City>>
    {
        public RequesterCity(string uriPart, string key) : base(uriPart, key)
        {
        }        

        public override List<City> GetResource(string name)
        {
            String url = uriP + name + "?" + key;
            String res = this.restRequest(url);
            return JsonConvert.DeserializeObject<List<City>>(res);
        }
    }
}
