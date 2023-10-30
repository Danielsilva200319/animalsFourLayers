using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string NombreCity { get; set; }
        public int IdDep { get; set; }
        public Department Departments { get; set; }
        public ClientAddress ClientAddresses { get; set; }
    }
}