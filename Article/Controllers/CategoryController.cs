using Article.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        Context Context = new Context();

        public IActionResult Index()
        {
            return View(Context.Categories.ToList());
        }
    }
}
