using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string pAadhar) : this()
        {
            this.Aadhar = pAadhar;
        }
        public Person(string pAadhar, string pMobile) : this(pAadhar)
        {
            this.MobileNumber = pMobile;
        }
        public enum gender
        {
            Male, Female
        }
        public string Name { get; set; }
        public string Aadhar { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

        protected string TaxDetails { get; set; }
        public string eat() 
        {
            return $"{this.Name} eats Breakfast, Lunch, Dinner";
        }
        public string sleep() {
            return $"{this.Name} sleeps 8hrs a day";
        }
        public virtual string Work() {
            return $"{this.Name} works for 4hrs, relaxes for 8hrs";
        }
        public gender persongender { get; set; }

    }
}
