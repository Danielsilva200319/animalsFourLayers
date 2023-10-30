using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly AnimalsContext _context;

        public DepartmentRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }
    }
}