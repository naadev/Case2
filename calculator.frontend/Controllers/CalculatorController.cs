using Microsoft.AspNetCore.Mvc;

namespace calculator.frontend.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string operation)
        {
            double num1 = Convert.ToDouble(firstNumber);
            double num2 = Convert.ToDouble(secondNumber);
            double result = 0;

            switch (operation)
            {
                case "Add":
                    result = 0;
                    break;
                case "Subtract":
                    result = 0;
                    break;
                case "Multiply":
                    result = 0;
                    break;
                case "Divide":
                    result = 0;
                    break;
            }

            ViewBag.Result = result;
            return View();
        }
    }
}
