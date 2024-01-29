using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ComprasRepository : Repository<Compra>, ICompraRepository
    {
        private ApplicationDbContext DbContext { get; }
        public ComprasRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }
    }
}
