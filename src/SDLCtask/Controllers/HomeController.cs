using Microsoft.AspNetCore.Mvc;

namespace SDLCtask.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Goals()
        {
            return View();
        }
    }
}