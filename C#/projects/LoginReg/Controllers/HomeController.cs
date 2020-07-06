using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private LoginRegContext db;
        public HomeController(LoginRegContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("CreateUser")]
        public IActionResult CreateUser(User user)
        {
            
            if(ModelState.IsValid)
            {
                if(db.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                db.Add(user);
                db.SaveChanges();
                return RedirectToAction("LoginPage");
            }
            return View("Index");
            
        }

        [HttpGet("LoginPage")]
        
            public IActionResult LoginPage()
            {
                return View("Login");
            }
        

        [HttpPost("LogUser")]
        public IActionResult LogUser(LoginUser user)
        {
            if(ModelState.IsValid)
        {
            var userInDb = db.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }
            
            var hasher = new PasswordHasher<LoginUser>();
            
            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
            
            if(result == 0)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                return View("Login");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");
            }
        }
            return View("Login");
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View("Success");
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
