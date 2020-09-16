using AspNetCore.Http.Extensions;
using AspNetCoreMVC_ECommerceApp.Abstractions;
using ECommerce_Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetCoreMVC_ECommerceApp.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient client;

        public ProductService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Product> Create(Product entity)
        {
            
            return await client.PostJsonAsync<Product>("api/products/",entity);
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            return await client.GetJsonAsync<List<Product>>("api/products/");
        }

        public async Task<List<Product>> GetAllProductWithCategory()
        {
            return await client.GetJsonAsync<List<Product>>("api/products/GetProductsWithCategory");
        }

        public Task<Product> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
