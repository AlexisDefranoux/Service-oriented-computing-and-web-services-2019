using System;
using System.Runtime.Serialization;

namespace Serveur
{
    [DataContract]
    public class Position
    {
        [DataMember]
        public double lat { get; set; }
        [DataMember]
        public double lng {get; set;}
    }
}