using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        string createpasscode()
        {
            string chars= "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            Random rand=new Random();
            string passsword="";
            for (var i=0;i<15;i++)
            {
                passsword+= chars[rand.Next(chars.Length)];
            }
            return passsword;
        }
        
        public IActionResult Index()
        {
            int? count =HttpContext.Session.GetInt32("count");
            if (count==null)
            {
                HttpContext.Session.SetInt32("count",1);
            }
            else
            {
                HttpContext.Session.SetInt32("count",(int)count+1);
            }
            ViewBag.Count = count;
            ViewBag.Password=createpasscode();
            
            return View();
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
