using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IPaisRepository Paises { get; }
        ICityRepository Cities { get; }
        IDepartmentRepository Departments { get; }
        IClientRepository Clients { get; }
        IPetRepository Pets { get; }
        IBreedRepository Breeds { get; }
        IServiceRepository Services { get; }
        IClientPhoneRepository ClientPhones { get; }
        IClientAddressRepository ClientAddresses { get; }
        ICitaRepository Citas { get; }
        Task<int> SaveAsync();
    }
}