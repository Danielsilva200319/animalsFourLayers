using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Dtos
{
    public class ClientAddressDto
    {
        public int Id { get; set; }
        public string TypeRoad { get; set; }
        public int NumberPri { get; set; }
        public string Letter { get; set; }
        public string Bis { get; set; }
        public string LetterSec { get; set; }
        public string Cardinal { get; set; }
        public int NumberSec { get; set; }
        public string LetterTer { get; set; }
        public int NumberTer { get; set; }
        public string CardinalSec { get; set; }
        public string Complement { get; set; }
        public string PostalCode { get; set; }
        public int IdCity { get; set; }
        public int IdClient { get; set; }
    }
}