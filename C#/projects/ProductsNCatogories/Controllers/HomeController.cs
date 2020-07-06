using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsNCatogories.Models;

namespace ProductsNCatogories.Controllers
{
    public class HomeController : Controller
    {
        private ProductsNCatogoriesContext db;
            public HomeController(ProductsNCatogoriesContext context)
            {
                db = context;
            }
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewModel NewView= new ViewModel();
            NewView.Products=db.Products.ToList();
            

            return View("Index",NewView);
        }
        [HttpGet("Categories")]
        public IActionResult Categories()
        {
            ViewModel NewView= new ViewModel();
            NewView.Categories=db.Categories.ToList();
            

            return View("Categories",NewView);
        }
        [HttpGet("Categories/{CategoryId}")]
        public IActionResult Categories(int CategoryId)
        {
            return RedirectToAction("Category",CategoryId);
        }
        [HttpGet("Category")]
        public IActionResult Category(int CategoryId)
        {
            ViewModel NewView= new ViewModel();
            NewView.Category=db.Categories.FirstOrDefault(c=>c.CategoryId==CategoryId);
            NewView.Products=db.Products.ToList();
            

            return RedirectToAction("Category",NewView);
        }
        
        [HttpGet("Product/{ProductId}")]
        public IActionResult Product(int ProductId)
        {
            Product CurrentProduct = db.Products
            .Include(Product=>Product.ProductsInCaegories)
            .ThenInclude(Product=>Product.Category)
            .FirstOrDefault(Product=>Product.ProductId==ProductId);

            List<Category> OtherCategories = db.Categories
                .Where(category => 
                    ! CurrentProduct.ProductsInCaegories.Any(association => association.CategoryId == category.CategoryId))
                .ToList();

            ViewModel NewView = new ViewModel()
            {
                Product = CurrentProduct,
                Categories = OtherCategories
            };

            return View("Product",NewView);
        }
        [HttpGet("Category/{CategoryId}")]
        public IActionResult SingleCategory(int CategoryId)
        {
            Category CurrentCategory = db.Categories
            .Include(Category=>Category.ProductsInCaegories)
            .ThenInclude(Category=>Category.Product)
            .FirstOrDefault(Category=>Category.CategoryId==CategoryId);

            List<Product> OtherProducts = db.Products
                .Where(product => 
                    CurrentCategory.ProductsInCaegories.Any(association => association.ProductId != product.ProductId))
                .ToList();

            ViewModel NewView = new ViewModel()
            {
                Category = CurrentCategory,
                Products = OtherProducts
            };

            return View("Category",NewView);
        }
        
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {
            if(ModelState.IsValid)
            {
            db.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            if(ModelState.IsValid)
            {
            db.Update(category);
            db.SaveChanges();
            return RedirectToAction("Categories");
            }
            return View("Categories");
        }
        [HttpPost("AddProductCategory")]
        public IActionResult AddProductCategory(ProductsInCaegory productsInCaegory)
        {
            int prodid=productsInCaegory.ProductId;
            if(ModelState.IsValid)
            {
            db.Update(productsInCaegory);
            db.SaveChanges();
            return RedirectToAction("");
            }
            return View("Categories");
        }
        [HttpPost("AddCategoryProduct")]
        public IActionResult AddCategoryProduct(ProductsInCaegory productsInCaegory)
        {
            int prodid=productsInCaegory.ProductId;
            if(ModelState.IsValid)
            {
            db.Update(productsInCaegory);
            db.SaveChanges();
            return RedirectToAction("Categories");
            }
            return View("Categories");
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
