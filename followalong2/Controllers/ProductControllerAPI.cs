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
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        ProductsDAO repository;
        public ProductControllerAPI()
        {
            repository = new ProductsDAO();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> Index()
        {
            return repository.GetAllProducts();
        }
        
        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> SearchResults(string searchTerm)
        {
            return repository.SearchProducts(searchTerm);
        }
        
        [HttpGet("showdetails/{id}")]
        public ActionResult<ProductModel> ShowDetails(int id)
        {
            return repository.GetProductById(id);
        }

        [HttpPost("ProcessInsert")]
        // post action
        // expecting a product in json format in the body of the request
        public ActionResult<int> ProcessInsert(ProductModel product)
        {
            int newId = repository.Insert(product);
            return newId;
        }

        [HttpPut("ProcessEdit")]
        // put request
        // expect a json formatted object in the body of the request. id number must match the item being modified
        public ActionResult<ProductModel> ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return repository.GetProductById(product.Id);
        }

        [HttpDelete("deleteone/{id}")]
        public ActionResult<bool> Delete(int id)
        {
            ProductModel product = repository.GetProductById(id);
            bool success = repository.Delete(product);
            return success;
        }
        /*
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
        }*/
    }
}
