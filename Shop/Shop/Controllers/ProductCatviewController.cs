using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductCatviewController : Controller
    {

        private readonly ShopContext db = new ShopContext();

        public IActionResult Index()
        {
            return View(db.ProductCatview.ToList());
        }
    }
}
