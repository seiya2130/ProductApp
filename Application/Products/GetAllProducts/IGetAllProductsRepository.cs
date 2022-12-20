using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetAllProducts
{
    public interface IGetAllProductsRepository
    {
        List<Product> GetAllProducts();
    }
}
