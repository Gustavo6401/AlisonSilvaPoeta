using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface IProdutoPedidoServices : IServicesBase<ProdutoPedidoViewModel, ProdutoPedido>
    {
        Task<List<ProdutoPedidoViewModel>> GetByCompraId(int id);
    }
}
