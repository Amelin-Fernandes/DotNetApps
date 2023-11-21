using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models
{
    public class Person
    {
        [Required]
        public string Aadhar { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(10, 110)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
    //this is a utility class - only static function
    public class PersonOperations
    {
        private static List<Person> _people = new List<Person>();
        public static List<Person> GetPeople()
        {
            if (_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "AA3456789012", Age = 28, Email = "meena@gmail.com", Name = "Meena" });
                _people.Add(new Person() { Aadhar = "BB8765432134", Age = 24, Email = "tina@gmail.com", Name = "Tina" });
                _people.Add(new Person() { Aadhar = "CC4567893425", Age = 22, Email = "reena@gmail.com", Name = "Reena" });
            }
            return _people;
        }

        public static Person Search(string pAadhar)
        {
            return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
        }

        public static List<Person> PeopleOfAge(int pStartAge, int pEndAge)
        {
            return GetPeople().Where(p => p.Age >= pStartAge && p.Age <= pEndAge).ToList();
        }

        public static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }

        public static bool Update(string pAadhar, Person updatedPerson)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                found.Email = updatedPerson.Email;
                found.Name = updatedPerson.Name;
                found.Age = updatedPerson.Age; //no updated aadhar because primary key
                return true;
            } 
            else
                throw new Exception("No such record"); //throw exception when you know its complicated (best practice)
        }

        public static bool Delete(string pAadhar)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                GetPeople().Remove(found);
                return true;
            }
            else
                throw new Exception("No such record"); 
        }
    }
}
