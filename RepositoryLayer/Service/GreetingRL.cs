using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {
        private readonly GreetingDbContext _context;
        private readonly ILogger<GreetingRL> _logger;

        public GreetingRL(GreetingDbContext context, ILogger<GreetingRL> logger)
        {
            _context = context;
            _logger = logger;
        }

        public GreetingEntity GetGreetingById(int id)
        {
            return _context.Greetings.FirstOrDefault(g => g.Id == id);
        }

        public bool DeleteGreeting(int id)
        {
            var greeting = _context.Greetings.FirstOrDefault(g => g.Id == id);
            if (greeting == null)
            {
                _logger.LogWarning($"Greeting with ID {id} not found.");
                return false;
            }

            _context.Greetings.Remove(greeting);
            _context.SaveChanges();
            _logger.LogInformation($"Greeting with ID {id} deleted successfully.");
            return true;
        }
    }
}
