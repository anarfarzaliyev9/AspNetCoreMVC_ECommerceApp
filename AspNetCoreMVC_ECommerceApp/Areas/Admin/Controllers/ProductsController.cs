using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC_ECommerceApp.Abstractions;
using AspNetCoreMVC_ECommerceApp.Areas.Admin.ViewModels;
using AspNetCoreMVC_ECommerceApp.Extensions;
using AutoMapper;
using ECommerce_Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ECommerceApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment webHost;
        private readonly IMapper mapper;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IWebHostEnvironment webHost,IMapper mapper,
            IProductService productService,ICategoryService categoryService)
        {
            this.webHost = webHost;
            this.mapper = mapper;
            this.productService = productService;
            this.categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            AddProductViewModel model = new AddProductViewModel();
            model.Categories = await categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(
         [Bind("Name","FormFile","Price","Details", "CategoryId","Categories", "IsFeatured", "IsNewArrival")]AddProductViewModel model)
        {         
            if (ModelState.IsValid)
            {
                Product product = new Product();
                var fileName = await model.FormFile.SaveAsync(webHost.WebRootPath, "ProductImages");
                model.PhotoPath = fileName;
                // Map properties of viewModel to product
                mapper.Map(model,product);
                var result= await productService.Create(product);
                if (result != null)
                {
                    return RedirectToAction("Admin","ManageProducts");
                }
            }
            model.Categories = await categoryService.GetAll();            
            return View(model);
        }
    }
}