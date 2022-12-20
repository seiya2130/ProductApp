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
            var products = getAllProductsRepository.GetAllProducts();

            var outputDataList = products.Select(x =>
                new GetAllProductsOutputData() { Name = x.Name, Price = x.Price}
            ).ToList();

            return outputDataList;
        }
    }
}
