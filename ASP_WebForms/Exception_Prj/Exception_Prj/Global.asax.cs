using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace Exception_Prj
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exobj = Server.GetLastError();
            Server.ClearError();

            string str = "";
            str += "" + exobj.Message + " " + exobj.Source + " " + exobj.InnerException.Message;
            //trying to log the errors onto a physical file
            string path = @"C:\Banu\2026\DotNet\ASP_WebForms\AllErrors.txt";
            File.AppendAllText(path, str);
            //Response.Write(str);
            Response.Redirect("~/apperror.html");

        }
    }
}