using ECommerce_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC_ECommerceApp.Abstractions
{
    public interface IProductService:IGeneralService<Product>
    {
        Task<List<Product>> GetAllProductWithCategory();
    }
}
