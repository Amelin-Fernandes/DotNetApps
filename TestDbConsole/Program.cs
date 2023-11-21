// See https://aka.ms/new-console-template for more information
using TestDal;
using TestDbConsole;

Console.WriteLine("Hello, World!");

CrudEf<Parent>.Add("Seema",true);
CrudEf<Parent>.Add("Master Varun",false);
CrudEf<Parent>.Add("Master Varun",false);

CrudEf<Parent>.Update("Master Varun", "Baby Barbie");

CrudEf<Parent>.Add("Imposter Hacker", false);

CrudEf<Parent>.Delete("Imposter Hacker");

var result = CrudEf<Parent>.SearchOne("Master Varun");
Console.WriteLine($"Search matches: {result.Name}");

//Get records
CrudEf<Parent>.Get() //Parent is datatype
         .ToList()
         .ForEach((p) => {
             if (p.IsActive == true)
                 Console.WriteLine($"{p.Name} is an {p.IsActive} parent");
             else
                 Console.WriteLine($"{p.Name} is a child");
         });



