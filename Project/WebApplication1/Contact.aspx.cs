using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        public string originAddress = "Paris";
        public string destinationAddress = "Marseille";
        protected void Page_Load(object sender, EventArgs e)
        {
            originAddress = Request.QueryString["originAddress"];
            destinationAddress = Request.QueryString["destinationAddress"];
        }
    }
}