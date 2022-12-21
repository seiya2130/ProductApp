using Application.Products.GetAllProducts;
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
        private readonly GetAllProductsPresenter getAllProductsPresenter = new GetAllProductsPresenter();

        public ProductsController(IGetAllProducts getAllProducts, GetAllProductsPresenter getAllProductsPresenter)
        {
            this.getAllProducts = getAllProducts;
            this.getAllProductsPresenter = getAllProductsPresenter;
        }

        public List<GetAllProductsViewModel> GetAllProducts()
        {
            var a = this.getAllProducts.Handle();
            var b = this.getAllProductsPresenter.Complete(a);
            return b;
        }

        public IHttpActionResult GetProduct(int id)
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