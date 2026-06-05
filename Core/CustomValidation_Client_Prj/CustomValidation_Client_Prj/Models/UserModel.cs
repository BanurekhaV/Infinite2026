using System.ComponentModel.DataAnnotations;
using CustomValidation_Client_Prj.CustomValidations;

namespace CustomValidation_Client_Prj.Models
{
    public class UserModel
    {
       [Required]
        public string ? UserName {get; set;}
        [Required(ErrorMessage="Enter valid date")]
        [Display(Name ="Date of Birth")]
        [MinimumAge(18)]
        public DateTime DOB { get; set;}
    }
}
