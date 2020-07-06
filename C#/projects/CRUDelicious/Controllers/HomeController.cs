using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
    private CRUDeliciousContext Db;
	public HomeController(CRUDeliciousContext context)
	{
	    Db = context;
	}
    [HttpGet("")]

        public IActionResult Index()
        {
            List<Dish> AlllDishes= Db.Dishs.ToList();
            return View("Index",AlllDishes);
        }
    [HttpGet("addDish")]

        public IActionResult AddDish()
        {
            return View("AddDish");
        }
    [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish dish)
        {
            Db.Add(dish);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("dishinfo/{Id}")]
        public IActionResult DishInfo(int Id)
        {
            Dish dish=Db.Dishs.FirstOrDefault(d=>d.DishrId==Id);
            return View("DishInfo",dish);
        }
        [HttpGet("dishinfo/Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            Dish dish=Db.Dishs.FirstOrDefault(d=>d.DishrId==Id);
            Db.Remove(dish);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("dishinfo/Edit/{Id}")]
        public IActionResult Edit(int Id)
        {
            Dish dish=Db.Dishs.FirstOrDefault(d=>d.DishrId==Id);
            return View("EditDish",dish);
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
