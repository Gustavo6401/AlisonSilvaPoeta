using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;

namespace AlisonSilvaPoeta.Repositories
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(LivrariaContext dbContext) : base(dbContext)
        {
        }
    }
}
