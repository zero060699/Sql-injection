using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login1
{
    public partial class Search : System.Web.UI.Page
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
       

        protected void btnGetAllProducts_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["PriceConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct", con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void btnGetProductByName_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["PriceConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            /*SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct where Name='" + TextBox1.Text + "'", con);*/
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct where Name=@Name", con);
            cmd.Parameters.Add(new SqlParameter("@Name", TextBox1.Text));
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
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