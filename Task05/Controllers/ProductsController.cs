using Microsoft.AspNetCore.Mvc;
using Task05.Models;

namespace Task05.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // Створюємо колекцію продуктів з випадковими значеннями
            var products = new List<Product>
        {
            new Product { Id = 1, Price = 10.99m, Name = "Product 1" },
            new Product { Id = 2, Price = 20.99m, Name = "Product 2" },
            new Product { Id = 3, Price = 30.99m, Name = "Product 3" }
        };

            // Передаємо дані у подання через ViewBag
            ViewBag.Products = products;

            // Передаємо дані у подання як модель
            return View(products);
        }
    }
}
