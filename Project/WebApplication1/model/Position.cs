using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.model
{
    public class Position
    {
        public double lat { get; set; }
        public double lng {get; set;}

        public override bool Equals(object obj)
        {
            var position = obj as Position;
            return position != null &&
                   lat == position.lat &&
                   lng == position.lng;
        }

        public override int GetHashCode()
        {
            var hashCode = 2124363670;
            hashCode = hashCode * -1521134295 + lat.GetHashCode();
            hashCode = hashCode * -1521134295 + lng.GetHashCode();
            return hashCode;
        }
    }
}