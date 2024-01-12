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
        public EnderecoServices(IMapper mapper, IEnderecoRepository repository) : base(mapper, repository)
        {
        }
    }
}
