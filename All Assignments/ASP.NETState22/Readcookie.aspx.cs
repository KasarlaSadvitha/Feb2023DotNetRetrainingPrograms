using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETState22
{
    public partial class Readcookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("ReadCookie is Loaded");
        }
        protected void ButtonClick(object sender , EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["myCookie"];

            lblTime.Text ="Time" + objCookie.Values["Time"];
            lblTime.ForeColor = System.Drawing.Color.FromName(objCookie.Values["ForeGroundC"]);
            lblTime.BackColor = System.Drawing.Color.FromName(objCookie.Values["BackGroundC"]);
            lblCurrentTime.Text = "Current Time" + DateTime.Now.ToString();

        }
    }
}