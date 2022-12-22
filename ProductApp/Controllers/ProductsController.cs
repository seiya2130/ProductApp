using Application.Products.GetAllProducts;
using Application.Products.GetProduct;
using InMemoryInfrastructure.Products;
using ProductApp.Controllers.GetProduct;
using ProductsApp.Controllers.GetAllProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IGetAllProducts getAllProducts;
        private readonly GetAllProductsPresenter getAllProductsPresenter;

        private readonly IGetProduct getProduct;
        private readonly GetProductPresenter getProductPresenter;

        public ProductsController(IGetAllProducts getAllProducts, IGetProduct getProduct)
        {
            this.getAllProducts = getAllProducts;
            this.getAllProductsPresenter = new GetAllProductsPresenter();

            this.getProduct = getProduct;
            this.getProductPresenter = new GetProductPresenter();
        }

        public List<GetAllProductsViewModel> GetAllProducts()
        {
            var getAllProductsOutputDataList = this.getAllProducts.Handle();
            return this.getAllProductsPresenter.Complete(getAllProductsOutputDataList);
        }

        public GetProductViewModel GetProduct(int id)
        {
            var getProductOutputData = this.getProduct.Handle(new GetProductInputData(id));
            return this.getProductPresenter.Complete(getProductOutputData);
        }
    }
}