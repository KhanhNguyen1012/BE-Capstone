﻿using Data.Repositories.Interfaces;
using Domain.Entities;

namespace Data.Repositories.Implementations
{
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(BirdFarmMealSystemContext context) : base(context)
        {
        }
    }
}
