﻿using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IGreetingRL
    {
        GreetingEntity GetGreetingById(int id);
    }
}
