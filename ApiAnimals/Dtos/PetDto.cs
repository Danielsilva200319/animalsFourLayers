using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Dtos
{
    public class PetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int IdBreed { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdClient { get; set; }
    }
}