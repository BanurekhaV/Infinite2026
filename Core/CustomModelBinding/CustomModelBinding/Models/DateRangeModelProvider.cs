using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBinding.Models
{
    public class DateRangeModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            //on the model type represented by the current instance
            if (context.Metadata.ModelType == typeof(DateRange))
            {
                return new DateRangeModelBinder();
            }
            return null;
        }
    }
}
