using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> GetByUserId(int id);
    }
}
