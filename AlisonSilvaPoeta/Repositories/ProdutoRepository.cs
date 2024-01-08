using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;

namespace AlisonSilvaPoeta.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(LivrariaContext dbContext) : base(dbContext)
        {
        }
    }
}
