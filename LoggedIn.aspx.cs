using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login1
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (string)(Session["uname"]);
            if (name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                userLabel.Text = name.ToString();
            }
            
        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx", false);
        }
    }
}