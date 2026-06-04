using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace CustomModelBinding.Models
{
    public class DateRangeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            //getting the query string parameter
            var query = bindingContext.HttpContext.Request.Query;

            var DateRangeQueryString = query["range"].ToString();

            if(string.IsNullOrEmpty(DateRangeQueryString))
            {
                return Task.CompletedTask;
            }
            //split the value
            var datevalues = DateRangeQueryString.Split('-');
            if(datevalues.Length !=2)
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Invalid Date Range format");
                return Task.CompletedTask;
            }
            if (datevalues.Length == 2 && DateTime.TryParseExact(datevalues[0], "MM/dd/yyyy", culture, DateTimeStyles.None, out DateTime startdate) &&
                DateTime.TryParseExact(datevalues[1], "MM/dd/yyyy", culture, DateTimeStyles.None, out DateTime enddate))
            {
                var daterange = new DateRange { StartDate = startdate , EndDate = enddate};
                bindingContext.Result = ModelBindingResult.Success(daterange);
                return Task.CompletedTask;
            }
            else
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName,
                    "Invalid Date");
                return Task.CompletedTask;
            }
        }
    }
}
