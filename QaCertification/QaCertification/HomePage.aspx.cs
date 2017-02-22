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
        SqlCommand cmd;
        SqlDataReader read;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Documents\\abel\\projects\\asp.net\\QaCertification\\QaCertification\\App_Data\\Database1.mdf';Integrated Security=True");
            try
            {
                con.Open();
                page_Load_Data();
            }
            catch (Exception ee)
            {
                Response.Write("Having some techincial issues, please try again later");
            }

            Response.Write("");
        }

        private void page_Load_Data()
        {

        }
    }
}