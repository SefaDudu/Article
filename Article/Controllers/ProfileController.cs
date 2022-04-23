using Article.Models;
using Article.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Article.Controllers
{
    public class ProfileController : Controller
    {
        Context Context = new Context();
        public IActionResult Index()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Name);
            var getUser = Context.Users.FirstOrDefault(x => x.Email == userEmail);
            var adress = Context.Addresses.Where(x => x.UserId == getUser.Id).ToList();
            ProfileVm profileVm = new ProfileVm() {
                Users = getUser,
                Address = adress

            };
            return View(profileVm);
        }
        [HttpPost]
        public IActionResult DeleteAdress(int id)
        {
           
            var adress = Context.Addresses.FirstOrDefault(x => x.Id == id);
            Context.Addresses.Remove(adress);
            Context.SaveChanges();
        
            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Name);
            var getUser = Context.Users.FirstOrDefault(x => x.Email == userEmail);
            address.UserId = getUser.Id;
            Context.Addresses.Add(address);
            Context.SaveChanges();

            return Redirect("Index");
        }
    }
}
