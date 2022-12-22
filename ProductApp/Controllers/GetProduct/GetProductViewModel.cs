using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Controllers.GetProduct
{
    public class GetProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GetProductViewModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
