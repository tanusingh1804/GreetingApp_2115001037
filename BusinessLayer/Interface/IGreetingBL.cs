using RepositoryLayer.Entity;

namespace BusinessLayer.Interface
{
    public interface IGreetingBL
    {
        GreetingEntity GetGreetingById(int id);
    }
}
