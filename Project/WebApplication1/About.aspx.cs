using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelibGuiClient.VelibService;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            System.Diagnostics.Debug.WriteLine("Cities :" + serviceClient.GetCitiesAsync());
        }
    }
}