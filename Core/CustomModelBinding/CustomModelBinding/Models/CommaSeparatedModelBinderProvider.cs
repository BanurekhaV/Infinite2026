using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBinding.Models
{
    public class CommaSeparatedModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType != typeof(List<int>))
            {
                return new CommaSeparatedModelBinder();
            }
            return null;
        }
    }
}
