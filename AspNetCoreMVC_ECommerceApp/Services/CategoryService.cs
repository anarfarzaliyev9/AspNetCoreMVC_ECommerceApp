using AspNetCoreMVC_ECommerceApp.Abstractions;
using ECommerce_Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspNetCoreMVC_ECommerceApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient client;

        public CategoryService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<Category> Create(Category entity)
        {
            return await client.PostJsonAsync<Category>("api/categories/", entity);
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(Category entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAll()
        {
            return await client.GetJsonAsync<List<Category>>("api/categories/");
        }

        public Task<Category> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
