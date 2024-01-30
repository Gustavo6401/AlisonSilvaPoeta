using AlisonSilvaIdentityUser.Data;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ApplicationUserRepository(ApplicationDbContext dbContext)
    {
        public async Task<ApplicationUser> GetByUserName(string userName)
        {
            return await dbContext.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == userName);
        } 
    }
}
