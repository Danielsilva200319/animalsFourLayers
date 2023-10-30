using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ClientAddress : BaseEntity
    {
        [Required]
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
        [Required]
        public int IdCity { get; set; }
        public City Cities { get; set; }
        [Required]
        public int IdClient { get; set; }
        public Client Clients { get; set; }
    }
}