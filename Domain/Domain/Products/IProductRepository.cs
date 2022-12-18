using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Products
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProduct(int id);
    }
}
