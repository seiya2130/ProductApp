using Application.Products.GetProduct;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InMemoryInfrastructure.Products
{
    public class GetProductRepository : IGetProductRepository
    {
        public Product GetProduct(int id)
        {
            var product = InMemoryProduct.products.FirstOrDefault((x) => x.Id == id);

            if (product == null)
            {
                product = new Product();
            }

            return product;
        }
    }
}
