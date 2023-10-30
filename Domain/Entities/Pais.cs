using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pais : BaseEntity
    {
        public string NamePais { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}