using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using followalong2.Models;

namespace followalong2.Services
{
    interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    }
}
