using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private IAccessories _log;

        public CarController(Car c, IApiLogger logger, IAccessories log)
        {
            _car = c;
            _logger = logger;
            _log = log;
            _logger.Log("CarController instance is created");
            _log.Log("CarController instance is created");
        }
        [HttpGet("/drive")]
        public IActionResult Drive() //dummy web func
        {
            _logger.Log("Driving() api called successfully");
            return Ok("Driving at 100kmph");
        }
    }
}
