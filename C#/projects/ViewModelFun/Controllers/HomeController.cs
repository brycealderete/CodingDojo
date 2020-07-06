using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home ()
        {
            string newstring= new string ("this is my new string i am creating to puta on the view render page.");
            return View("Home",newstring);
        } 
        [HttpGet("nums")]
        public IActionResult Numbers ()
        {
                int[] newints= new int[] 
                {
                    1,2,3,4,5,6,7
                };
            return View(newints);
            
        } 
        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> users=new List<User>() {
                new User("Bryce","Alderete"),
                new User("Destinee","Alderete"),
                new User("Jubran","Carter"),
                new User("Ernesto","Jasso-Hawkins")


            };
            return View(users);
        }
        [HttpGet("user")]
        public IActionResult User()
        {
            User user1=new User("Ernesto","Jasso-Hawkins");
            return View(user1);
        }
        
    }
}