using System.Collections.Generic;
using System.Web.Http;

namespace ProductsApp.Controllers.GetAllProducts
{
    public class GetAllProductsViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GetAllProductsViewModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}