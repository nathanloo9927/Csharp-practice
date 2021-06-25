using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using followalong2.Models;
using followalong2.Services;
using Microsoft.AspNetCore.Mvc;

namespace followalong2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();
            return View(products.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("Index", productList);
        }
        
        public IActionResult SearchForm()
        {
            return View();
        }
    }
}
