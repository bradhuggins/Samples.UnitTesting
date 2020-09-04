using Microsoft.AspNetCore.Mvc;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{input}")]
        public IActionResult Get(string input)
        {
            var toReturn = _service.GenerateMessage(input);
            return Ok(toReturn);
        }
    }
}
