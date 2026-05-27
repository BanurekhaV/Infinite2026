using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using CustomValidations_Prj.CustomValidations;

namespace CustomValidations_Prj.Models
{
    public class JobApplication 
    {
        [Required]
        [DisplayName("Applicant Name")]
        public string name {  get; set; }
        [Display(Name ="Years Of Experience")]
        [Range(3,10,ErrorMessage ="Experience must be between 3 and 10 years ")]
        public int experience {  get; set; }
        [DisplayName("DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage = "DOB should be between 01/01/1994 and 31/12/2002 only")]
        public DateTime birthdate { get; set; }
        [Display(Name ="Email ID")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter Valid Email Format")]
        public string email {  get; set; }
        [GenderValidate(ErrorMessage ="Please select your Gender")]
        public string Gender { get; set; }
        [Display(Name ="Expected Salary")]
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$", ErrorMessage =
            "Salary should be like 60000.45")]
        public decimal expsal {  get; set; }
        [SkillValidate(ErrorMessage ="Select a Minimum of 3 skills")]
        public List<CheckBox> Skills { get; set; }
        [Required]
        public string HavePassport {  get; set; }
    }
}