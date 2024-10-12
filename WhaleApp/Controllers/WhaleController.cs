using Microsoft.AspNetCore.Mvc;
using WhaleApp.Models;

namespace WhaleApp.Controllers
{
    public class WhaleController : Controller
    {
        private WhaleContext context;

        public WhaleController(WhaleContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var whale = context.Whales.Find(id);

            return View(whale);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var whale = context.Whales.Find(id);
            return View(whale);
        }

        [HttpPost]
        public IActionResult Edit(Whale whale)
        {
            if (ModelState.IsValid)
            {
                context.Whales.Update(whale);
                context.SaveChanges();
                return RedirectToAction("Whale", "View", whale.Id);
            }
            else
            {
                return View(whale);
            }
        }
    }
}
