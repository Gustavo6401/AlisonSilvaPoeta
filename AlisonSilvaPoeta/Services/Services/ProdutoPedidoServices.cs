using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
{
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
}
