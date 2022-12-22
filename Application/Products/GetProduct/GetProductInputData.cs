using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Application.Products.GetProduct
{
    public class GetProductInputData
    {
        public int Id { get; set; }

        public GetProductInputData(int id)
        {
            this.Id = id;
        }
    }
}
