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
    public partial class Default : System.Web.UI.Page
    {
        string queryStr;
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEventMethod(object sender, EventArgs e)
        {
            //if (checkAgainstWhiteList(usernameTextBox.Text) == true &&
              //  checkAgainstWhiteList(passwordTextBox.Text) == true)
            //{
                DoSQLQuery();
            //}
            //else
            //{
              //  passwordTextBox.Text = "Does not pass write List test";
            //}
            
        }
       /* private bool checkAgainstWhiteList(string userInput)
        {
            var regExpression = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9]*$");
            if (regExpression.IsMatch(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        private void DoSQLQuery()
        {
           /* try
            {*/
                string connString = ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                queryStr = "";
            /*queryStr = "SELECT * FROM userregistration WHERE username='" + usernameTextBox.Text + "' AND password= '" + passwordTextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(queryStr, con);*/

            queryStr = "SELECT * FROM userregistration WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(queryStr, con);
            cmd.Parameters.Add(new SqlParameter("@username", usernameTextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@password", passwordTextBox.Text));
            SqlDataReader reader = cmd.ExecuteReader();
                name = "";
            while (reader.HasRows && reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("firstname")) + "" +
                    reader.GetString(reader.GetOrdinal("middlename")) + "" +
                    reader.GetString(reader.GetOrdinal("lastname"));
            }
            if (reader.HasRows)
                {
                    Session["uname"] = name;
                    Response.BufferOutput = true;
                    Response.Redirect("Search.aspx", false);
                }
                else
                {
                    passwordTextBox.Text = "invalid user";
                }
                reader.Close();
                con.Close();
           /* }
            catch(Exception e)
            {
                passwordTextBox.Text = e.ToString();
            }*/
        }
    }
}