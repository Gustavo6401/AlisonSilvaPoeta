using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private LivrariaContext DbContext { get; }
        public EnderecoRepository(LivrariaContext dbContext) : base(dbContext)
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
