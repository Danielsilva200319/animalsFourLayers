using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Dtos
{
    public class CitaDto
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Hour { get; set; }
        public int IdClient { get; set; }
        public int IdPet { get; set; }
        public int IdService { get; set; }
    }
}