namespace AlisonSilvaPoeta.Interfaces.Services.Base;

public interface IServices<T, U> where T : class where U : class
{
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
    Task<T> Get(int id);
    Task<List<T>> GetAll();
}
