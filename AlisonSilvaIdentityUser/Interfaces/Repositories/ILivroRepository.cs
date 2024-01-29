using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface ILivroRepository : IRepository<Livro>
    {
        Task<Livro> GetByProductId(int id);
    }
}
