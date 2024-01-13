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
        public ProdutoPedidoServices(IMapper mapper, IProdutoPedidoRepository repository) : base(mapper, repository)
        {
        }
    }
}
