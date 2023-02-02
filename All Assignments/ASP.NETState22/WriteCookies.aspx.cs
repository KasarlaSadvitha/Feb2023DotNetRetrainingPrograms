using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETState22
{
    public partial class WriteCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                HttpCookie objCookie = new HttpCookie("myCookie");

                DateTime now = DateTime.Now;
                objCookie.Values.Add("Time" , now.ToString());
                objCookie.Values.Add("ForeGroundC", "red");
                objCookie.Values.Add("BackGroundC" , "yellow");

                this.Response.Cookies.Add(objCookie);
            }
        }
        protected void btnRedirect_Click(object sender , EventArgs e)
        {
            Response.Redirect("Readcookie.aspx");
        }
    }
}