using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Department : BaseEntity
    {
        public string NameDep { get; set; }
        public int IdPais { get; set; }
        public Pais Paises { get; set; }
        public ICollection<City> Cities { get; set; }

    }
}