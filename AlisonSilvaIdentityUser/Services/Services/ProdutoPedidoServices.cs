using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services;

public class ProdutoPedidoServices : ServicesBase<ProdutoPedidoViewModel, ProdutoPedido>, IProdutoPedidoServices
{
    private IMapper Mapper { get; }
    private IProdutoPedidoRepository Repository { get; }
    public ProdutoPedidoServices(IMapper mapper, IProdutoPedidoRepository repository) : base(mapper, repository)
    {
        Mapper = mapper;
        Repository = repository;
    }

    public async Task<List<ProdutoPedidoViewModel>> GetByCompraId(int id)
    {
        List<ProdutoPedido> produtosPedidos = await Repository.GetByCompraId(id);

        return Mapper.Map<List<ProdutoPedidoViewModel>>(produtosPedidos);
    }
}
