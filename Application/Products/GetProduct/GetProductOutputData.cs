using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetProduct
{
    public class GetProductOutputData
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GetProductOutputData(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
