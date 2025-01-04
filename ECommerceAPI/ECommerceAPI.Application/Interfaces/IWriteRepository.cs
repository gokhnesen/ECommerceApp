﻿using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {

        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> models);
        bool Remove(T model);

        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<T> model);

        Task<bool> UpdateAsync(T model);

        Task<int> SaveAsync();


    }
}
