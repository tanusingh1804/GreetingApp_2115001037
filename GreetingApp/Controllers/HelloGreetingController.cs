using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entity;

namespace GreetingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingBL _greetingBL;

        public GreetingController(IGreetingBL greetingBL)
        {
            _greetingBL = greetingBL;
        }

        [HttpGet("{id}")]
        public IActionResult GetGreetingById(int id)
        {
            var greeting = _greetingBL.GetGreetingById(id);
            if (greeting == null)
            {
                return NotFound(new { message = "Greeting not found!" });
            }
            return Ok(greeting);
        }
    }
}
