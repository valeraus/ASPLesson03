using Microsoft.AspNetCore.Mvc;

namespace Task01.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(double num1, double num2)
        {
            double result = num1 + num2;
            ViewBag.Operation = "Add";
            ViewBag.Result = result;

            return View("Index");
        }

        public IActionResult Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            ViewBag.Operation = "Multiply";
            ViewBag.Result = result;

            return View("Index");
        }

        public IActionResult Divide(double num1, double num2)
        {
            double result = num1 / num2;
            ViewBag.Operation = "Divide";
            ViewBag.Result = result;

            return View("Index");
        }

        public IActionResult Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            ViewBag.Operation = "Subtract";
            ViewBag.Result = result;

            return View("Index");
        }
    }
}
