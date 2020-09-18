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

        public async Task Delete(string id)
        {
             await client.DeleteAsync($"api/products/{id}");
        }

        public async Task<bool> Edit(Product entity)
        {
          
            return await client.PutJsonAsync<bool>($"api/products/{entity.Id}", entity);
        }

        public async Task<List<Product>> GetAll()
        {
            return await client.GetJsonAsync<List<Product>>("api/products/");
        }

        public async Task<List<Product>> GetAllProductWithCategory()
        {
            return await client.GetJsonAsync<List<Product>>("api/products/GetProductsWithCategory");
        }

        public async Task<Product> GetById(string id)
        {
            return await client.GetJsonAsync<Product>($"api/products/{id}");
        }
    }
}
