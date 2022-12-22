using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.GetProduct
{
    public class GetProduct : IGetProduct
    {
        private readonly IGetProductRepository getProductRepository;

        public GetProduct(IGetProductRepository getProductRepository)
        {
            this.getProductRepository = getProductRepository;
        }

        public GetProductOutputData Handle(GetProductInputData getProductInputData)
        {
            var product = this.getProductRepository.GetProduct(getProductInputData.Id);
            return new GetProductOutputData(product.Name, product.Price);
        }
    }
}
