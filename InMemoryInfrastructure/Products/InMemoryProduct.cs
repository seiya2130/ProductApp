﻿using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace InMemoryInfrastructure.Products
{
    public static class InMemoryProduct
    {
        public static Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
    }
}
