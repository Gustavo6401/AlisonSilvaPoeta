using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
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
