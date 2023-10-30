using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class BreedRepository : GenericRepository<Breed>, IBreedRepository
    {
        private readonly AnimalsContext _context;

        public BreedRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }
    }
}