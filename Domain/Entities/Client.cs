using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        public ClientAddress ClientAddresses { get; set; }
        public ICollection<ClientPhone> ClientPhones { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}