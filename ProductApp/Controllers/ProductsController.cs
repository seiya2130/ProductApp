using Application.Products.GetAllProducts;
using Application.Products.GetProduct;
using ProductApp.Models;
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

        public ProductsController(IGetAllProducts getAllProducts)
        {
            this.getAllProducts = getAllProducts;
            this.getAllProductsPresenter = new GetAllProductsPresenter();
        }

        public List<GetAllProductsViewModel> GetAllProducts()
        {
            var getAllProductsOutputDataList = this.getAllProducts.Handle();
            return this.getAllProductsPresenter.Complete(getAllProductsOutputDataList);
        }

        public GetAllProductsViewModel GetProduct(int id)
        {
            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            return Ok();
        }
    }
}