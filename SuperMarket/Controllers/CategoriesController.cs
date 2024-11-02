using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;

namespace SuperMarket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit([FromRoute]int? id)
        {
            Product product = new Product
            {
                Name = "Base",
                Id = id,
                Description = $"Description of product {id}"
            };
            return View(product);
        }
    }
}
