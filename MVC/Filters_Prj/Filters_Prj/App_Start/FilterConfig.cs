using Filters_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_Prj.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
          //  filters.Add(new HandleErrorAttribute());
          filters.Add(new LogCustomExceptionFilters());
        }
    } 
}