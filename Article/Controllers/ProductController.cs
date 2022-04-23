using Article.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dapper;
using Article.ViewsModel;
using System;


namespace Article.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        

        public async Task<IActionResult> Index(string? id,  string? word)
        {
            var conn = context.Database.GetDbConnection();
            await conn.OpenAsync();

            ProductVm productVm = null;
            IEnumerable<Product> product = null;
            var query = "";

            if (word == null && id != null)
            {
                query = "select * from Products where CategoryId= " + id;
            }
            else
            {
                query = $"select * from Products WHERE Name LIKE '%{word}%'";
            }

            try
            {
                product = await conn.QueryAsync<Product>(query);
                productVm = new ProductVm()
                {
                    Product = product,
                    word = word,
                    count = product.Count()
                };
            }

            finally
            {
                conn.Close();
            }

            return View(productVm);
        }

        public IActionResult ProductDetail(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }


    }
}
