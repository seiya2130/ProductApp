using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetAllProducts
{
    public interface IGetAllProducts
    {
        List<GetAllProductsOutputData> Handle();
    }
}
