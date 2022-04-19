using Article.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Article.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();


        //public async Task<IActionResult> Index(string id)
        //{
        //    var conn = context.Database.GetDbConnection();
        //    var query = "select * from products where CategoryId = " + id;
        //    IEnumerable<Product> product;

        //    try
        //    {
        //        await conn.OpenAsync();

        //        product = await conn.QueryAsync<Product>(query);
        //    }

        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return View(product);
        //}


    }
}
