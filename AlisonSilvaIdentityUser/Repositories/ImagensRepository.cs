using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ImagensRepository : Repository<Imagens>, IImagensRepository
    {
        public ImagensRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
