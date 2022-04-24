using Article.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.ViewsModel
{
    public class ProductDetailVm
    {
        public Product Product { get; set; }
        public List<CommentVm> CommentVm { get; set; }
    }
}
