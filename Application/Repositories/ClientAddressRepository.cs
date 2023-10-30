using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ClientAddressRepository : GenericRepository<ClientAddress>, IClientAddressRepository
    {
        private readonly AnimalsContext _context;

        public ClientAddressRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }
    }
}