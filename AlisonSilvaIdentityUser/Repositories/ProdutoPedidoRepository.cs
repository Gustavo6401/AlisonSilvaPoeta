using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ProdutoPedidoRepository : Repository<ProdutoPedido>, IProdutoPedidoRepository
    {
        private ApplicationDbContext DbContext { get; }
        public ProdutoPedidoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<List<ProdutoPedido>> GetByCompraId(int id)
        {
            List<ProdutoPedido> produtoPedidos = await DbContext.ProdutoPedidos.Where(t => t.ProdutoId == id)
                .ToListAsync();

            return produtoPedidos;
        }
    }
}
