using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductsController : Controller
    {


        private readonly ShopContext db = new ShopContext();

        public IActionResult Index()
        {
            var list = db.Products.ToList();
            return View(list);
        }

        public IActionResult inputform()
        {
            return View(db.Products.ToList());
        }

        public IEnumerable<Products> FindbyId(string code)

        {
            var item = db.Products.Where(s => s.PCode.Equals(code)).ToList();

            return item;

        }


        public IActionResult ProductPrice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductPrice(Products p)
        {


            Products p1 = new Products
            {
                PName = p.PName,
                PCode = p.PCode,
                PPrice = p.PQuantity * p.PCost,
                PQuantity = p.PQuantity,
                PCost = p.PCost,
                CCode=p.CCode,
            };
            db.Products.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");


        }


        public List<Products> UpdatebyId(string code)

        {
            


            var item1 = db.Products.Where(s => s.PCode.Equals(code)).Select(x => x.PName).FirstOrDefault();

            item1 = "Redmi";

            
            db.SaveChanges();


            var item = db.Products.Where(s => s.PCode.Equals(code)).ToList();


            return item;

        }
        public IActionResult demo()
        {
            return View();
        }
    }
}
