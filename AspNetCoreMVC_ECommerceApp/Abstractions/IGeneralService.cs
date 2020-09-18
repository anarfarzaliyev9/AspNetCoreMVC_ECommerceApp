using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC_ECommerceApp.Abstractions
{
    public interface IGeneralService<T>
    {
        Task<List<T>> GetAll();

        Task<T> GetById(string id);
        Task<T> Create(T entity);
        Task<bool> Edit(T entity);
        Task Delete(string id);
    }
}
