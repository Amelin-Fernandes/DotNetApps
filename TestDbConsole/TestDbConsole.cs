using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDal;

namespace TestDbConsole
{
    public class CrudEf<T> where T : Parent //base= new derived is done use the parent
    {
        static TestDbContext dbContext = new TestDbContext();

        public static void Add(string pName, bool pIsActive) {
            dbContext.Parents.Add(new Parent() { Name = pName, IsActive = pIsActive });
            dbContext.SaveChanges();
        }
        public static void Update(string pName, string pUpdatedValue) { //include parameters wherever we have done hard coding to make it generic
            var tobeupdated = dbContext.Parents
                             .ToList()
                             .Where((p) => p.Name == pName) //change "Seema" to pName
                             .FirstOrDefault(); 

            tobeupdated.Name = pUpdatedValue; //change "Baby Barbie" to pUpdatedValue
            dbContext.SaveChanges();
        }

        public static void Delete(string pName)
        {
            var tobedeleted = dbContext.Parents
                           .ToList()
                           .Where((p) => p.Name == pName)
                           .FirstOrDefault();
            dbContext.Parents.Remove(tobedeleted);
            dbContext.SaveChanges();
        }
        public static List<T> Get() {
            return dbContext.Parents.ToList() as List<T>;
        }
        public static T SearchOne(string pName) {
            var result = dbContext.Parents
                                .ToList()
                                .Where(p => p.Name == pName)
                                .FirstOrDefault();
            return result as T;
        }

    }
}
