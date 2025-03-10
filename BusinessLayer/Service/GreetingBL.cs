using BusinessLayer.Interface;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;

namespace BusinessLayer.Service
{
    public class GreetingBL : IGreetingBL
    {
        private readonly IGreetingRL _greetingRL;
        private readonly ILogger<GreetingBL> _logger;

        public GreetingBL(IGreetingRL greetingRL, ILogger<GreetingBL> logger)
        {
            _greetingRL = greetingRL;
            _logger = logger;
        }

        public GreetingEntity GetGreetingById(int id)
        {
            return _greetingRL.GetGreetingById(id);
        }

        public bool DeleteGreeting(int id)
        {
            _logger.LogInformation($"Request received to delete greeting with ID {id}");
            return _greetingRL.DeleteGreeting(id);
        }
    }
}
