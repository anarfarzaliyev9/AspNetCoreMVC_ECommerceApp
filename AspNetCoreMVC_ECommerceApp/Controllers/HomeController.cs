using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreMVC_ECommerceApp.Models;
using AspNetCoreMVC_ECommerceApp.Abstractions;
using AspNetCoreMVC_ECommerceApp.ViewModels;
using ECommerce_Models;

namespace AspNetCoreMVC_ECommerceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await productService.GetAllProductWithCategory();
            IndexViewModel model = new IndexViewModel();
            model.FeaturedProducts = products.Where(p => p.IsFeatured == true).ToList();
            model.NewArrivalProducts = products.Where(p => p.IsNewArrival == true).ToList();
            return View(model);
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public async Task<IActionResult> GetProductsByCategory(string categoryName)
        {
            //Send categoryname to view for breadcrumb
            ViewBag.CategoryName = categoryName;
            //Get all products
            List<Product> products = await productService.GetAllProductWithCategory();
            GetByCategoryViewModel model = new GetByCategoryViewModel();
            //Fill view model produts
            model.Products = products.Where(p => string.Equals(p.Category.Name, categoryName, StringComparison.OrdinalIgnoreCase)).ToList();
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
