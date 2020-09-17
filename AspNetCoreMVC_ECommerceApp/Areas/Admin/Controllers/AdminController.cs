using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC_ECommerceApp.Abstractions;
using AspNetCoreMVC_ECommerceApp.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ECommerceApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IProductService productService;

        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ManageProducts()
        {
            ManageProductsViewModel model =new  ManageProductsViewModel();
            model.Products = await productService.GetAllProductWithCategory();
            return View(model);
        }
    }
}