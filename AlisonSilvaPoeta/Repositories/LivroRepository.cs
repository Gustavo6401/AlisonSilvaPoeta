using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta.Repositories
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        private readonly LivrariaContext DbContext;
        public LivroRepository(LivrariaContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<Livro> GetByProductId(int id)
        {
            Livro? livro = await DbContext.Livros.FirstOrDefaultAsync(l => l.Id.Equals(id));

            return livro;
        }
    }
}
