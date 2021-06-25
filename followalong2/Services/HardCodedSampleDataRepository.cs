using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using followalong2.Models;

namespace followalong2.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count <= 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "nyeh", Price = 5.99m, Description = "My favorite line by Himiko" });
                productsList.Add(new ProductModel { Id = 2, Name = "magic", Price = 399.99m, Description = "Another Himiko saying" });
                productsList.Add(new ProductModel { Id = 3, Name = "degenerate male", Price = 19.99m, Description = "My favorite line by Tenko" });
                productsList.Add(new ProductModel { Id = 4, Name = "danganronpa V3", Price = 6969.69m, Description = "The game that these 2 characters came from" });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
