using EmpDal;
//using EmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpConsole
{
    public class CrudEmpEf<T> where T : EmpDal.Employee
    {
        static EmpDbContext dbContext = new EmpDbContext();

        public static void Add(string pName, bool pIsActive)
        {
            dbContext.Employees.Add(new EmpDal.Employee() { EmpName = pName, IsActive = pIsActive });
            dbContext.SaveChanges();
        }
        public static void Update(string pName, string pUpdatedValue)
        { //include parameters wherever we have done hard coding to make it generic
            var tobeupdated = dbContext.Employees
                             .ToList()
                             .Where((p) => p.EmpName == pName) //change "Seema" to pName
                             .FirstOrDefault();

            tobeupdated.EmpName = pUpdatedValue; //change "Baby Barbie" to pUpdatedValue
            dbContext.SaveChanges();
        }

        public static void Delete(string pName)
        {
            var tobedeleted = dbContext.Employees
                           .ToList()
                           .Where((p) => p.EmpName == pName)
                           .FirstOrDefault();
            dbContext.Employees.Remove(tobedeleted);
            dbContext.SaveChanges();
        }
        public static List<T> Get()
        {
            return dbContext.Employees.ToList() as List<T>;
        }
        public static T SearchOne(string pName)
        {
            var result = dbContext.Employees
                                .ToList()
                                .Where(p => p.EmpName == pName)
                                .FirstOrDefault();
            return result as T;
        }
    }
}
