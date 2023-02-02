using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetState
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ListBox1.Items.Add("EEE");
                ListBox1.Items.Add("Mech");
                ListBox1.Items.Add("CSE");
            }
        }
        protected void btnClick(object sender , EventArgs e)
        {
            Response.Write("Hello Post Back");
        }
    }
}