using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;
using System.Security.Cryptography.X509Certificates;
/*
namespace SampleWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people", Name = "GetAllPeople", Order = 2)]
        [HttpGet("/ppl", Name = "GetPpl", Order = 1)]
        [HttpGet("/persons", Name = "GetPersons", Order = 3)]
        //public IActionResult GetPeople()
        //{
            //Get the model class and do something
            

            //Display a View
            //return View("PeopleList", people); //View that takes model data as input 
        //}

        //backend
        /*
        public IActionResult AccessRoute()
        {
            var response = PersonOperations.GetPeople();
            var uri = Url.Link("GetAllPeople", "created");
            return Created(uri, "created");
        }

        [HttpGet("/search/{pAadhar}")]
        public IActionResult GetPersonDetail(string pAadhar)
        {
            //call model class method
            var found = PersonOperations.Search(pAadhar);

            //return the view with matching person object
            return View("Search", found);
        }

        [HttpGet("/PeopleOfAge/{pStartAge}/{pEndAge}")]
        public IActionResult GetPeopleWithinAge(int pStartAge, int pEndAge)
        {
            //call model class method
            var agebetween = PersonOperations.PeopleOfAge(pStartAge, pEndAge);

            //return the view with matching person object
            return View("PeopleOfAge", agebetween);
        }

        //whenever you type any url it does http get request
        [HttpGet("/create")]
        public IActionResult Create() {
            return View("Create", new Person());
        }
        //whenever we click ok button what should happen is written over here
        [HttpPost("/create")]
        //below it takes form input and deserializes it into Person class
        public IActionResult Create([FromForm] Person p) //the things in [] are known as ModelBinders; frombody means body tag of html and fromform means form tag of html
        {
            //call model method from personOperations
            PersonOperations.CreateNew(p);
            return View("PeopleList", PersonOperations.GetPeople());
        }
        [HttpGet("/edit/{pAadhaar}")]
        public IActionResult Edit(string pAadhaar)
        {
            var found = PersonOperations.Search(pAadhaar);
            return View("Edit", found);
        }
        [HttpPost("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar, [FromForm] Person p)
        {
            var found = PersonOperations.Search(p.Aadhar); //search the record then update
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOperations.GetPeople());
        }
    */
    //}
//}
