using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System.Linq;

namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {
        private readonly GreetingDbContext _context;

        public GreetingRL(GreetingDbContext context)
        {
            _context = context;
        }

        public GreetingEntity GetGreetingById(int id)
        {
            return _context.Greetings.FirstOrDefault(g => g.Id == id);
        }
    }
}
