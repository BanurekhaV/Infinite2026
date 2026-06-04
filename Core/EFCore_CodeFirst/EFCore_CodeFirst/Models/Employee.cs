namespace EFCore_CodeFirst.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int DepartmentId {  get; set; }

        public Department? Department { get; set; }
    }

}
