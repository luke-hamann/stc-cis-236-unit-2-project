using Microsoft.AspNetCore.Mvc;
using WhaleApp.Models;

namespace WhaleApp.Controllers
{
    public class HomeController : Controller
    {
        private WhaleContext context;

        public HomeController(WhaleContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            ViewBag.Whales = whales;
            return View(whales);
        }
    }
}
