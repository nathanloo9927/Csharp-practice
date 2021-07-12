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
        ProductsDAO repository;
        public ProductController()
        {
            repository = new ProductsDAO();
        }

        public IActionResult Index()
        {
            return View(repository.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            return View("Index", repository.SearchProducts(searchTerm));
        }
        
        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult ShowDetails(int id)
        {
            return View(repository.GetProductById(id));
        }

        public IActionResult ShowDetailsJSON(int id)
        {
            return Json(repository.GetProductById(id));
        }

        public IActionResult Edit(int id)
        {
            return View("ShowEdit", repository.GetProductById(id));
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return View("Index", repository.GetAllProducts());
        }

        public IActionResult ProcessEditReturnPartial(ProductModel product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);
        }

        public IActionResult Delete(int id)
        {
            ProductModel product = repository.GetProductById(id);
            repository.Delete(product);
            return View("Index", repository.GetAllProducts());
        }

        public IActionResult Create()
        {
            return View("ShowCreateForm");
        }

        public IActionResult ProcessInsert(ProductModel product)
        {
            repository.Insert(product);
            return View("Index", repository.GetAllProducts());
        }
    }
}
