using Application.Products.GetAllProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetProduct
{
    public interface IGetProduct
    {
        GetProductOutputData Handle(GetProductInputData getProductInputData);
    }
}
