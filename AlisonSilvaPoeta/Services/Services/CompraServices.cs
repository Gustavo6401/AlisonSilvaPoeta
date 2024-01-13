using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
{
    public class CompraServices : ServicesBase<CompraViewModel, Compra>, ICompraServices
    {
        private IMapper Mapper { get; }
        private ICompraRepository Repository { get; }
        public CompraServices(IMapper mapper, ICompraRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }
    }
}
