using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services.Base;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services.Base;

public class ServicesBase<T, U> : IServices<T, U> where T : class where U : class
{
    public IMapper Mapper;
    public IRepository<U> Repository;

    public ServicesBase(IMapper mapper, IRepository<U> repository)
    {
        Mapper = mapper;
        Repository = repository;
    }
    public virtual async Task Add(T entity)
    {
        U data = Mapper.Map<U>(entity);

        await Repository.Add(data);
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Get(int id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<List<T>> GetAll()
    {
        List<U> all = await Repository.All();

        return Mapper.Map<List<T>>(all);
    }

    public Task Update(T entity)
    {
        throw new NotImplementedException();
    }
}
