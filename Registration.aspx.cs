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
    public partial class Registration : System.Web.UI.Page
    {
        string queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            string connString = ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            queryStr = "";
            queryStr = "INSERT INTO userregistration (firstname, middlename, lastname, email, phonenumber, username, password)" +
                "VALUES('" + firstnameTextBox.Text + "','" + middlenameTextBox.Text + "','" + lastnameTextBox.Text + "','" + emailTextBox.Text +
                "','" + phonenumberTextBox.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(queryStr, con);
            cmd.ExecuteReader();
            con.Close();
        }
    }
}