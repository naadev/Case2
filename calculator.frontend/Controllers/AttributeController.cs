using Microsoft.AspNetCore.Mvc;

namespace calculator.frontend.Controllers
{
    public class AttributeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string firstNumber)
        {
            ViewBag.IsPrime = "what?";
            return View();
        }
    }
}
