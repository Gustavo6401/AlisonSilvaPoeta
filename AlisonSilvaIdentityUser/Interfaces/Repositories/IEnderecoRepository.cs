using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<List<Endereco>> GetEnderecosByClienteId(int id);
    }
}
