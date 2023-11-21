using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApp.Models
{
    public class Employee
    {
        [Required]
        public int EmpId { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool IsActive { get; set; }
        public string Aadhar { get; set; }
        public string MobileNumber { get; set; }
    }

    public class EmployeeOperations
    {
        private static List<Employee> _employee = new List<Employee>();
        public static List<Employee> GetAllEmployees()
        {
            if (_employee.Count == 0)
            {
                _employee.Add(new Employee() { EmpId = 1001, Aadhar = "AAAA31245678", Designation = "Analyst", Salary = 500000.00, MobileNumber = "1234567890", IsActive= true});
                _employee.Add(new Employee() { EmpId = 1002, Aadhar = "BBBB56789012", Designation = "Consultant", Salary = 600000.00, MobileNumber = "9876543212", IsActive = true });
                _employee.Add(new Employee() { EmpId = 1003, Aadhar = "CCCC56789012", Designation = "Manager", Salary = 700000.00, MobileNumber = "6543287654", IsActive = false });
            }
            return _employee;
        }

        public static Employee Search(int pEmpId)
        {
            return GetAllEmployees().Where(p => p.EmpId == pEmpId).FirstOrDefault();
        }

        internal static void CreateNew(Employee e)
        {
            GetAllEmployees();
            _employee.Add(e);
        }
    }
}
