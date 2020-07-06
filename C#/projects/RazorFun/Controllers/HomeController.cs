using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class HomeController :Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("project")]
        public ViewResult Project()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}