using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Filters_Prj.Models
{
    public class LogCustomExceptionFilters : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.ExceptionHandled)
            {
                var exceptionMessage = filterContext.Exception.Message;
                var stackTrace = filterContext.Exception.StackTrace;
                var controllername = filterContext.RouteData.Values["controller"].ToString();
                var actionname = filterContext.RouteData.Values["action"].ToString();

                string Msg = "Date : " + DateTime.Now.ToString() + ", Controller Name : "+ controllername +
                    " , Action Name :" + actionname + ", Error Message :" +exceptionMessage
                    + Environment.NewLine + " , Stack Trace : " + stackTrace;

                //save the data as a text file or maybe a database
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/Log/Log.txt"), Msg);

                filterContext.ExceptionHandled = true;

                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"
                };
            }
        }
    }
}