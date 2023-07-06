using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task03.Models;

namespace Task03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Lesson.pdf");
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var mimeType = "application/pdf"; 
            return File(fileStream, mimeType, Path.GetFileName(filePath));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}