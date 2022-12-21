using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetAllProducts
{
    public class GetAllProductsOutputData
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GetAllProductsOutputData(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
