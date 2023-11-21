using EmployeeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        //a. GetAllEmployees()
        [HttpGet("/getemployees")]
        public IActionResult GetAllEmployees()
        {
            var employee = EmployeeOperations.GetAllEmployees();

            return View("EmployeeList", employee); 
        }

        [HttpGet("/search/{pEmpId}")]
        public IActionResult GetEmployeeDetail(int pEmpId)
        {
            var found = EmployeeOperations.Search(pEmpId);

            return View("Search", found);
        }

        //b.CreateEmployee()
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View("Create", new Employee());
        }
        
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Employee e)
        {
            EmployeeOperations.CreateNew(e);
            return View("EmployeeList", EmployeeOperations.GetAllEmployees());
        }

        //c.EditEmployee()
        [HttpGet("/edit/{pEmpId}")]
        public IActionResult Edit(int pEmpId)
        {
            var found = EmployeeOperations.Search(pEmpId);
            return View("Edit", found);
        }
        
        [HttpPost("/edit/{pEmpId}")]
        public IActionResult Edit(string pEmpId, [FromForm] Employee e)
        {
            var found = EmployeeOperations.Search(e.EmpId); //search the record then update
            found.EmpId = e.EmpId;
            found.Designation = e.Designation;
            found.Salary = e.Salary;
            found.Aadhar = e.Aadhar;
            found.MobileNumber = e.MobileNumber;
            return View("EmployeeeList", EmployeeOperations.GetAllEmployees());
        }

        public IActionResult GetEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("FromDb",empBl.GetEmployees());
        }

        public IActionResult InsertEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("InsertDb", empBl.InsertEmployees());
        }

        public IActionResult UpdateEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("UpdateDb", empBl.UpdateEmployees());
        }

        public IActionResult DeleteEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("DeleteDb", empBl.DeleteEmployees());
        }

    }
}
