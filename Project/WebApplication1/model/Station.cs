using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.model;

namespace WebApplication1
{
    public class Station
    {
        public int number { get; set; }
        public string contract_name { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Position position { get; set; }
    }
}