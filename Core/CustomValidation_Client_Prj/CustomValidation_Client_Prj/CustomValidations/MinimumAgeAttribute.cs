using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation_Client_Prj.CustomValidations
{
    public class MinimumAgeAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
            ErrorMessage = $"You must be at least {_minimumAge} Years Old.";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //check if the value is a valid DateTime
            if(value is DateTime dateofBirth)
            {
                //calculate the age
                var age = DateTime.Today.Year - dateofBirth.Year;

                if(dateofBirth.Date >DateTime.Today.AddYears(-age))
                {
                    age--; //adjust if birthday hasnt occurred yet in this year
                }

                //validate age
                if(age >= _minimumAge)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            //if the value is not Datetime return an error
            return new ValidationResult("Invalid Format for Date Of Birth");
        }

        // Implement IClientModelValidators AddValidation()
        public void AddValidation(ClientModelValidationContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            //Add data-val=true to enable validation for the field
            MergeAttributes(context.Attributes, "data-val", "true");

            //add mimimum age rule as data-val-mimimumage
            var errorMessage = FormatErrorMessage(context.ModelMetadata.GetDisplayName());
            MergeAttributes(context.Attributes,"data-val-minimumage",errorMessage);

            //add data-val-minimumage-min
            MergeAttributes(context.Attributes,"data-val-minimumage-min",_minimumAge.ToString());
        }

        private bool MergeAttributes(IDictionary<string,string> attributes, string key, string value)
        {
            if(attributes.ContainsKey(key))
            {
                return false;
            }
            attributes.Add(key, value);
            return true;
        }
    }
}
