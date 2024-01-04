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
    public virtual Task Add(T entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Update(T entity)
    {
        throw new NotImplementedException();
    }
}
