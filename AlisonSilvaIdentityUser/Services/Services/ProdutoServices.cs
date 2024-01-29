using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services;

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
