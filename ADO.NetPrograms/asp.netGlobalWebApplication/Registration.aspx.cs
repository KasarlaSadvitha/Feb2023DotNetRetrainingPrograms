using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netGlobalWebApplication
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                Response.Write("<br>Page is Posted Back");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            if(age<50 && age>18 && txtUserName.Text.Length>=6 && txtPassword.Text==txtConfirmPassword.Text )
            {
               // Print.InnerHtml == "User Name" + txtUserName.Text + "<br/" > ;
              // Print.InnerHtml
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}