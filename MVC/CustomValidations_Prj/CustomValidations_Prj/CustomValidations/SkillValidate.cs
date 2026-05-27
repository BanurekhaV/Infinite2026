using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomValidations_Prj.Models;
using System.ComponentModel.DataAnnotations;

namespace CustomValidations_Prj.CustomValidations
{
    public class SkillValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           List<CheckBox> skills_selected = value as List<CheckBox>;

            int count = skills_selected == null ? 0 : (from s in skills_selected
                                                       where s.IsChecked == true
                                                       select s).Count();

            if (count >= 3)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}