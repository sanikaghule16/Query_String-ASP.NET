using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read value from QueryString
            string name = Request.QueryString["name"];

            if (!string.IsNullOrEmpty(name))
            {
                lblResult.Text = "Received from QueryString: " + name;
            }
            else
            {
                lblResult.Text = "No data received.";
            }
        }
    }
}
