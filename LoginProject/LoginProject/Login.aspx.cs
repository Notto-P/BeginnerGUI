using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click1(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string pass = pw2.Text;
            if (username == "admin" && pass == "123456" || username == "ADMIN" && pass == "123456")
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("Erro");
            }
        }
    }
}