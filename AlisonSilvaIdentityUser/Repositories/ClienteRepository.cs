using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private ApplicationDbContext DbContext;
        public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<Cliente> GetByUserId(int id)
        {
            Cliente? cliente = await DbContext.Clientes.FirstOrDefaultAsync(t => t.UsuarioId == id);

            return cliente;
        }
    }
}
