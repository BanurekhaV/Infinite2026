using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding_Prj.Models;

namespace ModelBinding_Prj.CustomBindings
{
    public class CustomBinder : IModelBinder
    {
        public object BindModel(ControllerContext cContext, ModelBindingContext bindingContext)
        {
            var request = cContext.HttpContext.Request;
            string title = request.Form.Get("title");
            string day = request.Form.Get("day");
            string month = request.Form.Get("month");
            string year = request.Form.Get("year");

            return new CustomModel
            {
                Title = title,
                Date = day + "/" + month + "/" + year,
            };
        }
    }
}