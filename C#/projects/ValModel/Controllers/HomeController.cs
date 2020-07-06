using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValModel.Models;

namespace ValModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("user/Create")]
        public IActionResult Create(User user)
        {
            
            if(ModelState.IsValid)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            return View("dashboard");
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
