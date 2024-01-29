using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services
{
    public class EnderecoServices : ServicesBase<EnderecoViewModel, Endereco>, IEnderecoServices
    {
        private IMapper Mapper { get; }
        private IEnderecoRepository Repository { get; }
        public EnderecoServices(IMapper mapper, IEnderecoRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }

        public async Task<List<EnderecoViewModel>> GetEnderecosByClienteId(int id)
        {
            List<Endereco> endereco = await Repository.GetEnderecosByClienteId(id);

            return Mapper.Map<List<EnderecoViewModel>>(endereco);
        }
    }
}
