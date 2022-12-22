using Application.Products.GetAllProducts;
using Application.Products.GetProduct;
using ProductsApp.Controllers.GetAllProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Controllers.GetProduct
{
    public class GetProductPresenter
    {
        public GetProductViewModel Complete(GetProductOutputData getAllProductsOutputData)
        {
            return new GetProductViewModel(getAllProductsOutputData.Name, getAllProductsOutputData.Price);
        }
    }
}
