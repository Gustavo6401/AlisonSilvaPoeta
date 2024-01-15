using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta.Repositories
{
    public class ProdutoPedidoRepository : Repository<ProdutoPedido>, IProdutoPedidoRepository
    {
        private LivrariaContext DbContext { get; }
        public ProdutoPedidoRepository(LivrariaContext dbContext) : base(dbContext)
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
