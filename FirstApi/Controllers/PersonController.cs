using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //makes web funcs do automatic content negotiation
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/people")]
        public IActionResult GetPeople() //since Ok will give status code put IActionResult instead of List<Person>
        {
            _logger.Log("Start Logging GetPeople()");
            _logger.Log("GetPerson() api call successful");
            return Ok(PersonOperations.GetPeople());
        }
        [HttpPost("/api/create")]
        public IActionResult CreatePerson([FromForm]Person p)
        {
            PersonOperations.CreateNew(p);
            _logger.Log("CreatePerson() api call successful");
            return Created($"Created person with Aadhar {p.Aadhar} successfully",p);
        }

        [HttpPut("/api/update/{pAadhar}")]
        public IActionResult UpdatePerson([FromRoute]string pAadhar, [FromBody]Person updatedPerson)
        {
            try
            {
                PersonOperations.Update(pAadhar, updatedPerson);
                _logger.Log("UpdatePerson() api call successful");
                return Ok("Update successful");
            }
            catch(Exception ex) //catch can be many but one at a time will be executed, finally only once
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);
            }
            
        }
        [HttpDelete("/api/delete")] //Eg: https://localhost:7013/api/delete?pAadhar=ndjc&p2=2 (after ? query and &one more query)
        public IActionResult DeletePerson([FromQuery]string pAadhar) //parameter binder [fromquery]
        {
            try
            {
                PersonOperations.Delete(pAadhar);
                _logger.Log("DeletePerson() api call successful");
                return Ok("Deletion successful");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);
            }
            
        }
    }
}
