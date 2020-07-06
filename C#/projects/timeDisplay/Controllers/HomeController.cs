using System;
using Microsoft.AspNetCore.Mvc;

namespace timeDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.Time = DateTime.Now.ToString("h:mm:ss tt");
            ViewBag.Date =  DateTime.Today.ToString("dd/MM/yyyy");
            return View();
        }
    }
}