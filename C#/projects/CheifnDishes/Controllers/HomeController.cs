using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheifnDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace CheifnDishes.Controllers
{
    public class HomeController : Controller
    {
        private CheifnDishesContext db;
        public HomeController(CheifnDishesContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs=db.Chefs.Include(c=>c.Dishes).ToList();

            return View("Index",AllChefs);
        }
        [HttpGet("Dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes=db.Dishes.Include(d=>d.Chef).ToList();

            return View("Dishes",AllDishes);
        }
        [HttpGet("AddChef")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }
        [HttpPost("CreateChef")]
        public IActionResult CreateChef(Chef chef)
        {
            db.Add(chef);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("AddDish")]
        public IActionResult AddDish()
        {
            List<Chef> AllChefs=db.Chefs.ToList();
            ViewBag.Chefs=AllChefs;
            return View("AddDish");
        }
        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                db.Add(dish);
                db.SaveChanges();
                return RedirectToAction("Dishes");
            }
            List<Chef> AllChefs=db.Chefs.ToList();
            ViewBag.Chefs=AllChefs;
            return View("AddDish");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
