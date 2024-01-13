using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;

namespace AlisonSilvaPoeta.Repositories
{
    public class CompraRepository : Repository<Compra>, ICompraRepository
    {
        private LivrariaContext DbContext { get; }
        public CompraRepository(LivrariaContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }
    }
}
