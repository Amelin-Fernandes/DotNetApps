using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsingAsyncController : ControllerBase
    {
        public UsingAsyncController()
        {
            System.IO.File.WriteAllText(@"SomeFile.txt", "ha ha ha");
        }
        [HttpGet("/async")]
        public async Task<string> ReadFile() //everything in web api and mvc should be public
        {
            using (StreamReader r = new StreamReader(@"SomeFile.txt"))
            {
                return await r.ReadToEndAsync();
            }
        }
        [HttpGet("/delay")]
        public async Task<IActionResult> DoSomething() //everything in web api and mvc should be public
        {
            await Task.Delay(1000);
            return Ok("Delayed Task");

        }
    }
}
