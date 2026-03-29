using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Store value in ViewState
            ViewState["UserName"] = txtName.Text;

            lblMessage.Text = "Saved in ViewState: " + ViewState["UserName"].ToString();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            // Retrieve value from ViewState
            string name = txtName.Text;

            Response.Redirect("Second.aspx?name=" + name);
        }
    }
    
}
