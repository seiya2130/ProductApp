using Application.Products.GetAllProducts;
using Application.Products.GetProduct;
using InMemoryInfrastructure.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace ProductApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IGetAllProductsRepository, GetAllProductsRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGetAllProducts, GetAllProducts>(new HierarchicalLifetimeManager());

            container.RegisterType<IGetProductRepository, GetProductRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGetProduct, GetProduct>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
            // Web API の設定およびサービス
            // Web API ルート
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
