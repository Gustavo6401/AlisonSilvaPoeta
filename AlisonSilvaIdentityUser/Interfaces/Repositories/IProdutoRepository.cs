using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<List<Produto>>? ListarPorNome(string nome);
    }
}
