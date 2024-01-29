using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext DbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task Add(T entity)
        {
            DbContext.Set<T>().Add(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task<List<T>> All()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await Find(id);

            DbContext.Set<T>().Remove(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task<T> Find(int id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Detached;

            DbContext.Entry(entity).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }
    }
}
