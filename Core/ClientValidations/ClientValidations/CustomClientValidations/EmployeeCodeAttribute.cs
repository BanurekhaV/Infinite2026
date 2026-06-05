using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ClientValidations.CustomClientValidations
{
    public class EmployeeCodeAttribute : ValidationAttribute, IClientModelValidator
    {
        public override bool IsValid(object ? value)
        {
            if (value == null)
                return true;

            string? text = value.ToString();

            return text.StartsWith("EMP");
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-employeecode",
                ErrorMessage ?? "Code must start with EMP");
        }
    }
}
