using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class WeddingPlannerController  : Controller
    {
        private WeddingPlannerContext db;
        public WeddingPlannerController(WeddingPlannerContext context)
        {
            db = context;
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
        [HttpGet("WeddingPlanner")]
        public IActionResult WeddingPlanner()
        {
            // User CurrentUser = db.Users
            // .Include(use=>use.UsersgoingtoWeddings)
            // .ThenInclude(ugw=>ugw.Wedding)
            // .Include(u=>u.Weddings)
            // .FirstOrDefault(u=>u.UserId == uid);
            // List<Wedding> otherweddings =db.Weddings
            // .Where(Wedding=>
            // ! CurrentUser.UsersgoingtoWeddings.Any(a=>a.WeddingId == Wedding.WeddingId))
            // .ToList();

            // ViewModel newView = new ViewModel()
            // {
            //     User = CurrentUser,
            //     Weddings= otherweddings
            // };

            ViewModel newView = new ViewModel();
            newView.User=db.Users
            .Include(users=>users.Weddings)
            .ThenInclude(w=>w.UsersgoingtoWeddings)
            .Include(User=>User.UsersgoingtoWeddings)
            .ThenInclude(use=>use.Wedding)
            .FirstOrDefault(u=>u.UserId==uid);

            newView.Weddings=db.Weddings
            .Include(w=>w.UsersgoingtoWeddings)
            .ThenInclude(ug=>ug.Wedding)
            .Include(w=>w.User)
            .ToList();

            ViewBag.Rsvp=db.UserGoingtoWedding.ToList();




            return View("WeddingPlanner",newView);
        }
        [HttpGet("AddWedding")]
        public IActionResult AddWedding()
            {
                ViewModel newView= new ViewModel();
                newView.User=db.Users.FirstOrDefault(u=>u.UserId==uid);
                return View("CreateWedding",newView);
            }
            [HttpPost("CreateWedding")]
            public IActionResult CreateWedding(Wedding wedding)
            {
                if(ModelState.IsValid)
            {
                
                
                db.Add(wedding);
                db.SaveChanges();
                return RedirectToAction("WeddingPlanner");
            }
            return View("CreateWedding");
            }
            [HttpPost("DeleteUsersGoingToWeddings/{weddingId}")]
            public IActionResult DeleteUsersGoingToWeddings(int weddingId)
            {
                UserGoingtoWedding thisuser= db.UserGoingtoWedding.FirstOrDefault(u=>u.WeddingId==weddingId  && u.UserId== uid);
                    db.UserGoingtoWedding.Remove(thisuser);
                    db.SaveChanges();
                

                return RedirectToAction("WeddingPlanner");
            }
            [HttpPost("CreateUsersGoingToWeddings")]
            public IActionResult CreateUsersGoingToWeddings(UserGoingtoWedding userGoingtoWedding)
            {
                if(ModelState.IsValid)
                {
                    db.Add(userGoingtoWedding);
                    db.SaveChanges();
                }

                return RedirectToAction("WeddingPlanner");
            }
            [HttpPost("Delete/{weddingId}")]
            public IActionResult Delete(int weddingId)
            {
                Wedding thiswedding=db.Weddings.FirstOrDefault(w=>w.WeddingId == weddingId);
                    db.Remove(thiswedding);
                    db.SaveChanges();
                

                return RedirectToAction("WeddingPlanner");
            }
            [HttpGet("Wedding/{weddingId}")]
            public IActionResult Wedding (int weddingId)
            {

                ViewModel newmodel=new ViewModel();

                Wedding newWedding= db.Weddings.FirstOrDefault(w=>w.WeddingId==weddingId);
                

                newmodel.Wedding=newWedding;
                newmodel.UsersGoingtoWeddings=db.UserGoingtoWedding.Where(ugw=>ugw.WeddingId==weddingId)
                .Include(w=>w.User)
                .ToList();
                
                                
                

                return View("Wedding",newmodel);
            }
    }

}