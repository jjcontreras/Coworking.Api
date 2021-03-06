﻿using Dicres.RepositoryService.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicres.RepositoryService.Application.Contracts.Services
{
    public interface IBaseCrudService<T>
        where T : BaseBusinessModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
        Task<T> Update(T entity);
    }
}
