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
        public List<Product> GetAllProducts()
        {
            return InMemoryProduct.products.ToList();
        }
    }
}
