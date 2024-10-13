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
            ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            return View(ViewBag.Whales);
        }
    }
}
