using System.Collections.Generic;
using BusinessLayer.Interface;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service
{
    public class GreetingBL : IGreetingBL
    {
        private readonly IGreetingRL _greetingRL;

        public GreetingBL(IGreetingRL greetingRL)
        {
            _greetingRL = greetingRL;
        }

        public GreetingEntity GetGreetingById(int id)
        {
            return _greetingRL.GetGreetingById(id);
        }

        public List<GreetingEntity> GetAllGreetings() 
        {
            return _greetingRL.GetAllGreetings();
        }
    }
}
