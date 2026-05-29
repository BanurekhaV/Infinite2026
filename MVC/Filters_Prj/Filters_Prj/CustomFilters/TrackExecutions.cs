using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Filters_Prj.CustomFilters
{
    public class TrackExecutions : ActionFilterAttribute,IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = "\n" + 
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "------->" + filterContext.ActionDescriptor.ActionName + " ---- > OnAction Executing \t " +
                DateTime.Now.ToString() + "\n";
            LogExecutionStats(message);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string message = "\n" +
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "------->" + filterContext.ActionDescriptor.ActionName + " ---- > OnAction Executed \t " +
                DateTime.Now.ToString() + "\n";
            LogExecutionStats(message);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string message ="\n" + filterContext.RouteData.Values["controller"].ToString()+
                "---->" + filterContext.RouteData.Values["action"].ToString() +
                "----> On Result Executing \t "+ DateTime.Now.ToString() + "\n";
            LogExecutionStats(message);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string message = "\n" + filterContext.RouteData.Values["controller"].ToString() +
                "---->" + filterContext.RouteData.Values["action"].ToString() +
                "----> On Result Executed \t " + DateTime.Now.ToString() + "\n";
            LogExecutionStats(message);
        }

        public void OnException(ExceptionContext filterContext)
        {
            string message = "\n" + filterContext.RouteData.Values["controller"].ToString() +
               "---->" + filterContext.RouteData.Values["action"].ToString() +
               "----> OnException \t " + DateTime.Now.ToString() + "\n";
            LogExecutionStats(message);
        }

        private void LogExecutionStats(string info)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/DataFolder/Datafile.txt"), info);
        }
    }
}