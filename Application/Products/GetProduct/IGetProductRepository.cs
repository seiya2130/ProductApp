using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetProduct
{
    public interface IGetProductRepository
    {
        Product GetProduct(int id);
    }
}
