using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Products.GetAllProducts
{
    public class GetAllProducts : IGetAllProducts
    {
        private readonly IGetAllProductsRepository getAllProductsRepository;

        public GetAllProducts(IGetAllProductsRepository getAllProductsRepository)
        {
            this.getAllProductsRepository = getAllProductsRepository;
        }

        public List<GetAllProductsOutputData> Handle()
        {
            return this.getAllProductsRepository.GetAllProducts().Select(x => new GetAllProductsOutputData(x.Name, x.Price)).ToList();
        }
    }
}
