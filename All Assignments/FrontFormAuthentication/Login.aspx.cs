using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace FrontFormAuthentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((txtUserName.Text=="Dhiraj")&&(txtPassword.Text=="1234"))
                {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
            }
        }
    }
}