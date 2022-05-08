using Article.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dapper;
using Article.ViewsModel;
using System;
using System.Security.Claims;

namespace Article.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();


        public async Task<IActionResult> Index(string? id, string? word)
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

        [HttpGet]
        public IActionResult ProductDetail(int id )
        {
            var result = from comment in context.Comments
                         join users in context.Users
                             on comment.UserId equals users.Id
                         where comment.ProductId == id 
                         select new CommentVm { Comment = comment.Description, Email = users.Email, FirstName = users.Name, LastName = users.Surname };
           
            ProductDetailVm productDetailVm = new ProductDetailVm()
            {
                Product = context.Products.FirstOrDefault(x => x.Id == id),
                CommentVm = result.ToList()
            };
            return View(productDetailVm);
        }
        [HttpPost]
        public IActionResult ProductDetail(ProductDetailPostVm productDetailPostVm)
        {
            if (productDetailPostVm.Comment != null)
            {
                var userEmail = User.FindFirstValue(ClaimTypes.Name);
                var getUser = context.Users.FirstOrDefault(x => x.Email == userEmail);
                Comment comment = new Comment()
                {
                    Description = productDetailPostVm.Comment,
                    ProductId = productDetailPostVm.ProductId,
                    UserId = getUser.Id
                };
                context.Comments.Add(comment);
                context.SaveChanges();
            }

            var result = from comment in context.Comments
                         join users in context.Users
                             on comment.UserId equals users.Id
                         where comment.ProductId == productDetailPostVm.ProductId
                         select new CommentVm { Comment = comment.Description, Email = users.Email, FirstName = users.Name, LastName = users.Surname };

            ProductDetailVm productDetailVm = new ProductDetailVm()
            {
                Product = context.Products.FirstOrDefault(x => x.Id == productDetailPostVm.ProductId),
                CommentVm = result.ToList()
            };



            return View(productDetailVm);
        }


    }
} 
