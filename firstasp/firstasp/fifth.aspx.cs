using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstasp
{
    public partial class fifth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = (Int32.Parse(TextBox1.Text) * Int32.Parse(TextBox2.Text)).ToString();
        }
    }
}