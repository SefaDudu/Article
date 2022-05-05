using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Models
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines {
            get { return _cartLines; }
        }
        public void AddProduct(Product product) {
            var line = _cartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line == null)
            {
                _cartLines.Add(new CartLine() { 
                Product=product
                });
            }
        }
        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(x => x.Product.Id == product.Id);
        }

        public double Total() {
            return _cartLines.Sum(x => x.Product.UnitPrice);
        }

        public void Clear() {

            _cartLines.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
    }
}
