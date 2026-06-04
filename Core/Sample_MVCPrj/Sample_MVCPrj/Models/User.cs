using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sample_MVCPrj.Models
{
    public class User
    {
        [Required(ErrorMessage="Name is Required")]
        public string ? UserName {  get; set; }
        [Required(ErrorMessage="Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid Format")]
        public string? UserEmail {  get; set; }
    }
}
