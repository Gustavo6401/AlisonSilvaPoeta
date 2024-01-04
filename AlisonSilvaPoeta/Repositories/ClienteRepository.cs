using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;

namespace AlisonSilvaPoeta.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private LivrariaContext DbContext;
        public ClienteRepository(LivrariaContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }
    }
}
