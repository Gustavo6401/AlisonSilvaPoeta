using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services
{
    public class CompraServices : ServicesBase<CompraViewModel, Compra>, IComprasServices
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
