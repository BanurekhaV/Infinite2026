using ClientValidations.CustomClientValidations;

namespace ClientValidations.Models
{
    public class EmployeeViewModel
    {
        [EmployeeCode(ErrorMessage = "Employee code must start with EMP")]
        public string ?EmployeeCode { get; set; }
    }
}
