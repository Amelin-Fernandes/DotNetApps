using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace SampleWebApp.Models
{
    public class Person
    {
        [Required]
        public string Aadhar { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(10,110)]
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
            if(_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "AA3456789012", Age = 28, Email = "meena@gmail.com", Name = "Meena" });
                _people.Add(new Person() { Aadhar = "BB8765432134", Age = 24, Email = "tina@gmail.com", Name = "Tina" });
                _people.Add(new Person() { Aadhar = "CC4567893425", Age = 22, Email = "reena@gmail.com", Name = "Reena" });
            }
            return _people;
        }

        public static Person Search(string pAadhar)
        {
            return GetPeople().Where(p=>p.Aadhar == pAadhar).FirstOrDefault();
        }

        internal static List<Person> PeopleOfAge(int pStartAge, int pEndAge)
        {
            return GetPeople().Where(p => p.Age>=pStartAge && p.Age<=pEndAge).ToList();
        }

        public static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }
    }
}
