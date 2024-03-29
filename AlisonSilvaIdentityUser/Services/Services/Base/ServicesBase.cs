﻿using AlisonSilvaIdentityUser.Interfaces.Repositories.Base;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services.Base
{
    public class ServicesBase<T, U> where T : class where U : class
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

        public async Task<T> Get(int id)
        {
            U entity = await Repository.Find(id);

            return Mapper.Map<T>(entity);
        }

        public virtual async Task<List<T>> GetAll()
        {
            List<U> all = await Repository.All();

            return Mapper.Map<List<T>>(all);
        }
    }
}
