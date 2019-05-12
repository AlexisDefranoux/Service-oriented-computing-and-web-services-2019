using System;
using System.Runtime.Serialization;

namespace Serveur
{
    [DataContract]
    public class Station
    {
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public string contract_name { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public Position position { get; set; }

        public String status { get; set; }
        public int aviable_bikes { get; set; }
        public int available_bike_stands { get; set; }
    }
}