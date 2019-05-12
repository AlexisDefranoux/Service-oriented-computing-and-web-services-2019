using System;
using System.Runtime.Serialization;

namespace Serveur
{
    [DataContract]
    public class Station
    {
        private const int RAYON = 6173;
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

        public double Distance(Station o)
        {
            return RAYON * Math.Acos(Math.Sin(position.lat) * Math.Sin(o.position.lat) + Math.Cos(o.position.lat) * Math.Cos(position.lat) * Math.Cos(o.position.lng - position.lng));
        }

        public double Distance(Position o)
        {
            return RAYON * Math.Acos(Math.Sin(position.lat) * Math.Sin(o.lat) + Math.Cos(o.lat) * Math.Cos(position.lat) * Math.Cos(o.lng - position.lng));
        }
    }
}