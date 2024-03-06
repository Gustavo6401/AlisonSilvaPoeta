using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class DepoimentoRepository : Repository<Depoimentos>, IDepoimentoRepository
    {
        private readonly ApplicationDbContext _context;
        public DepoimentoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
