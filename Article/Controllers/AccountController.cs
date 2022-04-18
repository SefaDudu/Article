using Article.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Article.Controllers
{
    public class AccountController : Controller
    {
        Context Context = new Context();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(Login user)
        {
            var Login = Context.Users.FirstOrDefault(x => x.Email == user.Email && x.password == user.password);

            if (Login != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,Login.Email),
                    new Claim(ClaimTypes.NameIdentifier,Login.Id.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return Redirect("Category/Index");
            }


            return View();

        }

        [HttpPost]
        public IActionResult Register(Login user)
        {
            Users users = new Users()
            {
                Email=user.Email,
                password=user.password

            };

            Context.Users.Add(users);
            TempData["Success"] = "Başarılı İşlem";
            Context.SaveChanges();

            return RedirectToAction("Login");
        }


    }
}
