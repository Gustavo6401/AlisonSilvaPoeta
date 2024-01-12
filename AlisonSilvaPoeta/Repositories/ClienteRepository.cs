using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private LivrariaContext DbContext;
        public ClienteRepository(LivrariaContext dbContext) : base(dbContext)
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
