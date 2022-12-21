using Application.Products.GetAllProducts;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductsApp.Controllers.GetAllProducts
{
    public class GetAllProductsPresenter
    {
        public List<GetAllProductsViewModel> Complete(List<GetAllProductsOutputData> getAllProductsOutputData)
        {
            var getAllProductsViewModelList = new List<GetAllProductsViewModel>();

            getAllProductsOutputData.ForEach(x =>
                getAllProductsViewModelList.Add(new GetAllProductsViewModel(x.Name, x.Price))); ;

            return getAllProductsViewModelList;
        }
    }
}