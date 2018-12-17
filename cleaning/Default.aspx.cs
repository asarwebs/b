using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cleaning
{
    public partial class Default : System.Web.UI.Page
    {
        public string stripePublishableKey = WebConfigurationManager.AppSettings["pk_test_MjdqtaiOSqvgcP1UDyxzNaDB"];
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}