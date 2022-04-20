using Article.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dapper;

namespace Article.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();


        public async Task<IActionResult> Index(string id)
        {
            var conn = context.Database.GetDbConnection();
            var query = "select * from Products where CategoryId= " + id;
            IEnumerable<Product> product;

            try
            {
                await conn.OpenAsync();

                product = await conn.QueryAsync<Product>(query);
            }

            finally
            {
                conn.Close();
            }
            return View(product);
        }

        public IActionResult ProductDetail(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }


    }
}
