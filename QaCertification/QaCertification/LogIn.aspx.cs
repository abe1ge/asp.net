using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace QaCertification
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader r;

        protected void Page_Load(object sender, EventArgs e)
        {
            
           
            if (Session["role"] != null)
            {
                if (Session["role"].ToString() == "1")
                {
                    Response.Redirect("HomePage.aspx");
                }
            }

            connectToDatabase();

        }

        private void connectToDatabase()
        {
            //create a new sqlConnection objecting with the connection string as argument
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\abel\\projects\\asp.net\\QaCertification\\QaCertification\\App_Data\\Database1.mdf;Integrated Security=True");
            try
            {
                //try to open the connection
                con.Open();
            }
            catch (Exception)
            {
                //if it can't connect do this
                Response.Write("Having technical deficulities");
            }

            //create new sqlCommand object
            cmd = new SqlCommand();
            //tell the sql command to use the connection we just created
            cmd.Connection = con;
        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Users where username ='" + TextBoxUsername.Text + "' and password ='" + TextBoxPassword.Text + "'";

            r = cmd.ExecuteReader();
            if (r.Read())
            {
                Session["role"] = r["role"].ToString();
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Session.Abandon();
                TextBoxUsername.Text = "";
                TextBoxPassword.Text = "";
                LabelLogInError.Text = "Username or password incorrect, Please try again";
            }

            r.Close();
        }
    }
}