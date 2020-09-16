using ECommerce_API.Abstractions;
using ECommerce_API.Contexts;
using ECommerce_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_API.Models
{
    public class CategoryRepo : GeneralRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context)
            :base(context)
        {

        }
    }
}
