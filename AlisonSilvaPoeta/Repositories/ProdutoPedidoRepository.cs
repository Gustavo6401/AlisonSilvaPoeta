using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;

namespace AlisonSilvaPoeta.Repositories
{
    public class ProdutoPedidoRepository : Repository<ProdutoPedido>, IProdutoPedidoRepository
    {
        private LivrariaContext DbContext { get; }
        public ProdutoPedidoRepository(LivrariaContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }
    }
}
