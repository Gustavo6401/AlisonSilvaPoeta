using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface IProdutoPedidoRepository : IRepository<ProdutoPedido>
    {
        Task<List<ProdutoPedido>> GetByCompraId(int id);
    }
}
