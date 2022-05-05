using Article.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Article.Extensions;

namespace Article.Controllers
{
    public class CartController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddCart(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddProduct(product);

                HttpContext.Session.SetObject("Cart", cart);
            }
            
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.DeleteProduct(product);

                HttpContext.Session.SetObject("Cart", cart);
            }
           
            return RedirectToAction("Index");
        }

        public Cart GetCart() 
        {
            Cart cart = HttpContext.Session.GetObject<Cart>("Cart");
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObject("Cart", cart);
            }

            return cart;
        }

    }
}
