using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidations_Prj.CustomValidations
{
    public class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);

            DateTime mindt = Convert.ToDateTime("01/01/1994");
            DateTime maxdt = Convert.ToDateTime("31/12/2002");

            if(entered_dob >= mindt  && entered_dob <= maxdt)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}