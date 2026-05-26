using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ModelState_Prj.Models
{
    public class User
    {
        [Required(ErrorMessage ="First Name is Required")]
        [DisplayName("First Name")]
        [StringLength(20,ErrorMessage ="First name cannot be more than 20 characters")]
        public string Fname {  get; set; }
        [Display(Name ="Last Name")]
        public string Lname {  get; set; }
        [DisplayName("Users Age")]
        [Range(21,45,ErrorMessage ="Age has to be between 21 and 45 only")]
        public int age {  get; set; }
        [Required(ErrorMessage ="Please Enter your Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$",
            ErrorMessage ="Invalid Format")]
        public string Email { get; set; }
        [EmailAddress]
        public string MyEmail { get; set; }
    }
}