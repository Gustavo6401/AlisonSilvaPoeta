using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services
{
    public class ClienteServices : ServicesBase<ClienteViewModel, Cliente> , IClienteServices
    {
        private IMapper Mapper;
        private IClienteRepository Repository;
        public ClienteServices(IMapper mapper, IClienteRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }

        public async Task<ClienteViewModel> GetByUsuarioId(int id)
        {
            Cliente cliente = await Repository.GetByUserId(id);

            return Mapper.Map<ClienteViewModel>(cliente);
        }
    }
}
