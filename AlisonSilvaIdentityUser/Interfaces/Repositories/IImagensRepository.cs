using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.Interfaces.Repositories
{
    public interface IImagensRepository : IRepository<Imagens>
    {
        Task<List<Imagens>> GetByProductId(int id);
    }
}
