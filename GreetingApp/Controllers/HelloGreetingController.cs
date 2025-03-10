using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Entity;

namespace GreetingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingBL _greetingBL;
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(IGreetingBL greetingBL, ILogger<GreetingController> logger)
        {
            _greetingBL = greetingBL;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IActionResult GetGreetingById(int id)
        {
            var greeting = _greetingBL.GetGreetingById(id);
            if (greeting == null)
            {
                _logger.LogWarning($"Greeting with ID {id} not found.");
                return NotFound(new { message = "Greeting not found!" });
            }
            return Ok(greeting);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGreeting(int id)
        {
            _logger.LogInformation($"Received request to delete greeting with ID {id}");
            bool isDeleted = _greetingBL.DeleteGreeting(id);
            if (!isDeleted)
            {
                return NotFound(new { message = "Greeting not found!" });
            }

            return Ok(new { message = "Greeting deleted successfully!" });
        }
    }
}
