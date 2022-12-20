using Application.Products.GetAllProducts;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InMemoryInfrastructure.Products
{
    public class GetAllProductsRepository : IGetAllProductsRepository
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public List<Product> GetAllProducts()
        {
            return products.ToList();
        }
    }
}
