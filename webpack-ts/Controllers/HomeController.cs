using Microsoft.AspNetCore.Mvc;

namespace webpack_ts
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SayName()
        {
            return View();
        }
    }
}
