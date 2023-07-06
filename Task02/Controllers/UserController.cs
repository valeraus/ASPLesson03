using Microsoft.AspNetCore.Mvc;

namespace Task02.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            string ipAddress = Request.Headers["X-Forwarded-For"].FirstOrDefault() ?? HttpContext.Connection.RemoteIpAddress?.ToString();
            string browser = Request.Headers["User-Agent"].ToString();

            ViewBag.IPAddress = ipAddress;
            ViewBag.Browser = browser;

            return View();
        }
    }
}
