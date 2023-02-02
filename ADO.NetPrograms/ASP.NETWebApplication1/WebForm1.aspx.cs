using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETWebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int x;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Loaded");

            x++;
        }
       
protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello World"+x);
        }

       
    }
}