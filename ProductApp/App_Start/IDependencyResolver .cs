using Application.Products.GetAllProducts;
using InMemoryInfrastructure.Products;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace ProductApp
{
    public interface IDependencyResolver : IDependencyScope, IDisposable
    {
        IDependencyScope BeginScope();
    }
}
