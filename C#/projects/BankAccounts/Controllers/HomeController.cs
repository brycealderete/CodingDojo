using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using BankAccounts.Models;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private BankAccountsContext db;
        public HomeController(BankAccountsContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
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
                return RedirectToAction("Account");
            }
        }
            return View("Login");
        }

        [HttpGet("Account")]
        public IActionResult Account()
        {
            if (!isLoggedIn)
            {
                RedirectToAction("LoginPage");
            }
            List<Transaction> UserTrans=db.Transactions.Where(Transaction=>Transaction.UserId==uid)
            .OrderByDescending(t=>t.CreatedAt).ToList();
            ViewModel Wrapper=new ViewModel();
            Wrapper.User=db.Users.FirstOrDefault(u=>u.UserId==uid);
            Wrapper.Transactions=UserTrans;
            return View("Account",Wrapper);
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpPost("Deposit")]
        public IActionResult Deposit(Transaction transaction)
    
        {
            if (!isLoggedIn)
            {
                RedirectToAction("LoginPage");
            }
            User user1=db.Users.FirstOrDefault(u=>u.UserId==uid);
            double newBalance=user1.Balance+=transaction.Amount;
            user1.Balance=newBalance;
            user1.UpdatedAt=DateTime.Now;
            db.Transactions.Update(transaction);
            db.SaveChanges();
            db.Users.Update(user1);
            db.SaveChanges();
            return RedirectToAction("Account");
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
