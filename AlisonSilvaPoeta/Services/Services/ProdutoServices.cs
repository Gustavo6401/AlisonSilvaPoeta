using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
{
    public class ProdutoServices : ServicesBase<ProdutoViewModel, Produto>, IProdutoServices
    {
        private IMapper Mapper;
        private IProdutoRepository Repository;
        public ProdutoServices(IMapper mapper, IProdutoRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }
    }
}
