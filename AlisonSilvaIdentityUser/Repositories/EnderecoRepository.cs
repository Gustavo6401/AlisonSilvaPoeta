using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private ApplicationDbContext DbContext { get; }
        public EnderecoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<List<Endereco>> GetEnderecosByClienteId(int id)
        {
            List<Endereco>? enderecos = await DbContext.Endereco.Where(t => t.ClienteId == id)
                                                         .ToListAsync();

            return enderecos;
        }
    }
}
