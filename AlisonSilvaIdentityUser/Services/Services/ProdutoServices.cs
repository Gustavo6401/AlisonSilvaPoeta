using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services;

public class ProdutoServices : ServicesBase<ProdutoViewModel, Produto>, IProdutoServices
{
    private IMapper _mapper;
    private IProdutoRepository _repository;
    public ProdutoServices(IMapper mapper, IProdutoRepository repository) : base(mapper, repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<List<ProdutoViewModel>> ListarPorNome(string nome)
    {
        List<Produto>? listaProdutos = await _repository.ListarPorNome(nome)!;

        return _mapper.Map<List<Produto>, List<ProdutoViewModel>>(listaProdutos);
    }
}
