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
            ErrorMessage = $"You must be at least {_minimumAge} years old.";
        }

        // Override IsValid to implement server-side validation
        // Override IsValid to implement server-side validation
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
           
            // Check if the value is a valid DateTime
            if (value is DateTime dateOfBirth)
            {
                // Calculate age
                var age = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                {
                    age--; // Adjust if birthday hasn't occurred yet this year
                }

                // Validate age
                if (age >= _minimumAge)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    // Return error message (use custom message if provided)
                    return new ValidationResult(ErrorMessage);
                }
            }

            // If value is not a DateTime (e.g., null), return error (handled by [Required] if needed)
            return new ValidationResult("Invalid date of birth.");
        }
        
        
    // Implement IClientModelValidator to add data attributes
    public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            // Add data-val="true" to enable validation for this field
            MergeAttribute(context.Attributes, "data-val", "true");

            // Add data-val-minimumage (rule name) with the error message
            var errorMessage = FormatErrorMessage(context.ModelMetadata.GetDisplayName());
            MergeAttribute(context.Attributes, "data-val-minimumage", errorMessage);

            // Add data-val-minimumage-min (parameter) to pass the minimum age to the client
            MergeAttribute(context.Attributes, "data-val-minimumage-min", _minimumAge.ToString());
        }

        // Helper method to merge attributes (avoids overwriting existing ones)
        private bool MergeAttribute(IDictionary<string, string> attributes, string key, string value)
        {
            if (attributes.ContainsKey(key))
            {
                return false;
            }

            attributes.Add(key, value);
            return true;
        }
    }

}
