using System.Collections.Generic;
using RepositoryLayer.Entity;

namespace BusinessLayer.Interface
{
    public interface IGreetingBL
    {
        GreetingEntity GetGreetingById(int id);
        List<GreetingEntity> GetAllGreetings(); 
    }
}
