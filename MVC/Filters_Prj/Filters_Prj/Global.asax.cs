using Filters_Prj.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Filters_Prj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // 1. adding handle error attribute globally without filterconfig.cs
            //GlobalFilters.Filters.Add(new HandleErrorAttribute());

            //2. with filter config.cs
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
