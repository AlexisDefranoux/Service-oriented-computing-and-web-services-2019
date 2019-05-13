using System.Runtime.Serialization;

namespace Serveur
{
    [DataContract]
    public class City
    {
        [DataMember]
        public string name { get; set; }
    }
}