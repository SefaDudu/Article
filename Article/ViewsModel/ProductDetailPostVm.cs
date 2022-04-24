using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Article.ViewsModel
{
    public class ProductDetailPostVm
    {
        [DisplayName("ProductId")]
        public int ProductId { get; set; }
        [DisplayName("Comment")]
        public string? Comment { get; set; }
    }
}
