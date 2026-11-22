using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetProducts() 
        {
            var products = new List<Product>
            {
                new Product (){ID=10,Name="Laptop"},
                new Product (){ID=20,Name="Computer"}
            };
            return Json(products);
        }

        [HttpGet]
        public IActionResult GetProductByID(int ID)
        {
            if (ID < 0)
            {
                return BadRequest();
            }
            else if (ID == 0) { return RedirectToAction(nameof(Index)); }
            else if (ID < 10) { return NotFound(); }
            else return RedirectToAction(nameof(GetProducts));

        }
    }
}
