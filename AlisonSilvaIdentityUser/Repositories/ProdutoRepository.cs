using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
