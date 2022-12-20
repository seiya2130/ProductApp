using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Product.GetAllProducts
{
    public class GetAllProducts : IGetAllProducts
    {
        public List<GetAllProductsOutputData> Handle()
        {
            return new List<GetAllProductsOutputData>();
        }
    }
}
