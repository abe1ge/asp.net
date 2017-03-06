using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QaCertification
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader r;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].ToString() != "1")
                    {
                        Response.Redirect("LogIn.aspx");
                    }
                }
                else
                {
                    Response.Redirect("LogIn.aspx");
                }
            }


            connectToDatabase();

            getDataFromDB();

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

        private void getDataFromDB()
        {
            cmd.CommandText = "select * from QA_Personal where QAID =" + Request["ID"];

            r = cmd.ExecuteReader();
            if (r.Read())
            {
                TextBoxName.Text = r["Name"].ToString();
                TextBoxAddress.Text = r["Address"].ToString();
            }

            r.Close();
        }
    }


}
