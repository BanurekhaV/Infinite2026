using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBinding.Models
{
    public class CommaSeparatedModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var query = bindingContext.HttpContext.Request.Query;
            var Ids = query["Id"].ToString();

            if(string.IsNullOrEmpty(Ids)) 
            {
                  return Task.CompletedTask;
            }

            var values=Ids.Split(',').Select(int.Parse).ToList();
            bindingContext.Result = ModelBindingResult.Success(values);
            return Task.CompletedTask;
        }
    }
}
