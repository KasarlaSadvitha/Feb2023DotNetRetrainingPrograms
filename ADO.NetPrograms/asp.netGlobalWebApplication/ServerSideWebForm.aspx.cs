using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netGlobalWebApplication
{
    public partial class ServerSideWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>Session ID: " +Session.SessionID);
            if(Session.IsNewSession)
            {
                Application.Lock();
                Application["ApplicationCount"] = (int)Application["ApplicationCount"] + 1;
                Session["SessionCount"] = (int)Session["SessionCount"] + 1;
                Application.UnLock();
            }
            txtSession.Text = Session["SessionCount"].ToString();
            txtApplication.Text = Application["ApplicationCount"].ToString();

        }
        protected void btnHello(object sender, EventArgs e)
        {
            Response.Redirect("PAGE2.aspx");
        }
    }
}