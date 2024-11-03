using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;

namespace SuperMarket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var products = CatogriesRepository.getProducts();
            return View(products);
        }
        public IActionResult Add()
        {
            var product = new Product();
            return View(product);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if(CatogriesRepository.isProductEmpty(product))
            {
                ViewBag.error = true;
                return View(product);
            }
            CatogriesRepository.addProducts(product);
            return View("Index", CatogriesRepository.getProducts());
        }
        public IActionResult Edit([FromRoute]int? id)
        {
            var product = CatogriesRepository.getProductById(id.HasValue? id.Value : 0);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            CatogriesRepository.updateProduct(product.Id.HasValue ? product.Id.Value : 0, product);
            return View(product);
        }
    }
}
