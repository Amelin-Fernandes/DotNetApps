using EmpDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Employee: Person, EmployeeContract
    {
        public event EventHandler Join;
        public event EventHandler Resign;
        //ctor
        //call base class constructor
        public Employee() : base()
        {
            this.ViewContract();
            this.Sign();
            this.EmpId = new Random(1000).Next();
            EmpUtils.EmpCount++; //we did not instantiate EmpCount because 
        }

        public void TriggerJoinEvent()
        {
            this.Join.Invoke(this,null);
        }

        public void TriggerResignEvent()
        {
            this.Resign.Invoke(this, null);
        }

        //call other class constructor
        public Employee(string pAadhar) : this()
        {
            this.Aadhar = pAadhar;
        }

        public Employee(string pAadhar, string pMobile) : base(pAadhar, pMobile)
        {
            this.ViewContract();
            this.Sign();
            this.EmpId = new Random(1000).Next();
            EmpUtils.EmpCount++;
        }

        //variables inside the class are called fields
        private bool _contractSigned = false;
        private bool _hasReadContract = false;

        public void Sign()
        {
            _contractSigned = true;
        }
        public void ViewContract()
        {
            _hasReadContract = true; ;
        }
        // properties are variables with much higher level control
        private int _empId;
        public int EmpId { get { return _empId; } private set { _empId = value; } }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool IsActive { get; set; }
        public string AttendTraining(string pTraining) {
            return $"{this.Name} attended training {pTraining} and his designation is {Designation}";

        }
        public string FillTimesheet(List<string> pTasks) {
            var csvTask = "";
            foreach (var task in pTasks)
            {
                csvTask = $"{csvTask}, {task}";
            }

            return $"{this.Name} has worked on {csvTask} on {DateTime.Now.ToShortDateString()}";
        }

        public override string Work()
        {
            return $"{this.Name} with {this.EmpId} works for 8hrs a day at KPMG.";
        }  

        public string Work(string task)
        {
            return $"{this.Name} with {this.EmpId} has {task} assigned";
        }

        public void SetTaxInfo(string pTaxInfo) 
        {
            this.TaxDetails = pTaxInfo;
        }

        public string GetTaxInfo()
        {
            return $"{this.Name}: Your tax details are: {this.TaxDetails}";
        }

        public List<EmpDal.Employee> GetEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> InsertEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> UpdateEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> DeleteEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

    }
}
