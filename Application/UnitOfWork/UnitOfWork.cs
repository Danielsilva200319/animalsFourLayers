using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AnimalsContext _context;
        private PaisRepository _paises;
        private CityRepository _cities;
        private DepartmentRepository _departments;
        private ClientRepository _clients;
        private PetRepository _pets;
        private BreedRepository _breeds;
        private ServiceRepository _services;
        private ClientPhoneRepository _clientPhones;
        private ClientAddressRepository _clientAddresses;
        private CitaRepository _citas;
        private IRefreshToken _refreshTokens;
        private IRol _rols;
        private IUser _users;

        public UnitOfWork(AnimalsContext context)
        {
            _context = context;
        }

        public IPaisRepository Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }
        }

        public ICityRepository Cities
        {
            get
            {
                if (_cities == null)
                {
                    _cities = new CityRepository(_context);
                }
                return _cities;
            }
        }

        public IDepartmentRepository Departments
        {
            get
            {
                if (_departments == null)
                {
                    _departments = new DepartmentRepository(_context);
                }
                return _departments;
            }
        }

        public IClientRepository Clients
        {
            get
            {
                if (_clients == null)
                {
                    _clients = new ClientRepository(_context);
                }
                return _clients;
            }
        }

        public IPetRepository Pets
        {
            get
            {
                if (_pets == null)
                {
                    _pets = new PetRepository(_context);
                }
                return _pets;
            }
        }

        public IBreedRepository Breeds
        {
            get
            {
                if (_breeds == null)
                {
                    _breeds = new BreedRepository(_context);
                }
                return _breeds;
            }
        }

        public IServiceRepository Services
        {
            get
            {
                if (_services == null)
                {
                    _services = new ServiceRepository(_context);
                }
                return _services;
            }
        }

        public IClientPhoneRepository ClientPhones
        {
            get
            {
                if (_clientPhones == null)
                {
                    _clientPhones = new ClientPhoneRepository(_context);
                }
                return _clientPhones;
            }
        }

        public IClientAddressRepository ClientAddresses
        {
            get
            {
                if (_clientAddresses == null)
                {
                    _clientAddresses = new ClientAddressRepository(_context);
                }
                return _clientAddresses;
            }
        }

        public ICitaRepository Citas
        {
            get
            {
                if (_citas == null)
                {
                    _citas = new CitaRepository(_context);
                }
                return _citas;
            }
        }

        public IRefreshToken RefreshTokens
        {
            get
            {
                if (_refreshTokens == null)
                {
                    _refreshTokens = new RefreshTokenRepository(_context); 
                }
                return _refreshTokens;
            }
        }

        public IRol Rols
        {
            get
            {
                if (_rols == null)
                {
                    _rols = new RolRepository(_context); 
                }
                return _rols;
            }
        }

        public IUser Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context); 
                }
                return _users;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}