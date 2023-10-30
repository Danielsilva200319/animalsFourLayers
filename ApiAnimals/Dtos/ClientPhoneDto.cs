using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Dtos
{
    public class ClientPhoneDto
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Number { get; set; }
    }
}