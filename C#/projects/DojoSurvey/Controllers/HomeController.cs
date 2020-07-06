using System.Collections.Generic;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController: Controller
    {
        

        [HttpGet("")]
        public IActionResult Index()
        {
            Survey survey = new Survey();
            return View("Index",survey);
        }
        [HttpPost("Create")]
        public IActionResult Create(Survey survey)
        {
            

            if(ModelState.IsValid)
            {
                return RedirectToAction("Welcome",survey);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Welcome")]
        public IActionResult Welcome(Survey survey)
        {
            return View("hello",survey);
        }

    }
}