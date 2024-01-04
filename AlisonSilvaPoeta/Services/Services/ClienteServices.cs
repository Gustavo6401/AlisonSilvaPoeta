using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
{
    public class ClienteServices : ServicesBase<ClienteViewModel, Cliente>, IClienteServices
    {
        private IMapper Mapper;
        private IClienteRepository Repository;
        public ClienteServices(IMapper mapper, IClienteRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }
    }
}
