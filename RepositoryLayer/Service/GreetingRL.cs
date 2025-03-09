using System.Collections.Generic;
using System.Linq;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

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

        public List<GreetingEntity> GetAllGreetings() 
        {
            return _context.Greetings.ToList();
        }
    }
}
