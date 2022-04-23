using Article.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.ViewsModel
{
    public class ProductVm
    {
        public IEnumerable<Product>? Product { get; set; }

        public int? count  { get; set; }
        public string? word  { get; set; }
    }
}
