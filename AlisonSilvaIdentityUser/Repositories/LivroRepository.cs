using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        private readonly ApplicationDbContext DbContext;
        public LivroRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<Livro> GetByProductId(int id)
        {
            Livro? livro = await DbContext.Livros.FirstOrDefaultAsync(l => l.ProdutoId.Equals(id));

            return livro;
        }
    }
}
