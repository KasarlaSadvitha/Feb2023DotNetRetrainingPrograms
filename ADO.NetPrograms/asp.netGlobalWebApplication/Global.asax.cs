using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace asp.netGlobalWebApplication
{
    public class Global : HttpApplication
    {
       protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["ApplicationCount"] = 0;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["SessionCount"] = 0;
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }
        protected void Application_AuthenticaionRequest(object sender, EventArgs e)
        {

        }
        protected void Application_Error(object sender, EventArgs e)
        {

        }
        protected void Session_Endd(object sender, EventArgs e)
        {

        }
        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}