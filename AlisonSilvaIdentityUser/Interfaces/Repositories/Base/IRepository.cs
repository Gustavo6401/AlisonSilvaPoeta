namespace AlisonSilvaIdentityUser.Interfaces.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<List<T>> All();
        Task<T> Find(int id);
    }
}
