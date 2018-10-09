﻿using Coworking.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : IBaseWithIdEntity
    {
        Task<bool> Exists(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task DeleteAsync(int id);
        Task<T> Update(T entity);
        Task<T> Add(T entity);
    }
}
