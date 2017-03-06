using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QaCertification
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader r;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("LogIn.aspx");
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

        protected void page_Load_Data()
        {

            cmd.CommandText = "select * from QA_Personal";

            using (r = cmd.ExecuteReader())
            {

                while (r.Read())
                {
                    Response.Write(" <tr><td>" + r["Name"].ToString() + "</td>");
                    Response.Write(" <td>" + r["Address"].ToString() + "</td>");


                    if (Session["role"] != null && Session["role"].ToString() == "1")
                    {
                        Response.Write(" <td> <a href='Edit.aspx?ID=" + r["QAID"].ToString() + "'> Edit </a></td>");
                        Response.Write(" <td> <a href='Delete.aspx?ID=" + r["QAID"].ToString() + "'> Delete </a></td></tr>");
                    }
                    else if (Session["role"] != null && Session["role"].ToString() == "2")
                    {
                        Response.Write(" <td>" + r["QAID"].ToString() + "Edit</td>");
                        Response.Write(" <td>" + r["QAID"].ToString() + "</td></tr>");
                    }

                }
            }
        }
    }
}