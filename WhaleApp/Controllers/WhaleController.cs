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
            ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            return View("Detail", whale);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            return View("WhaleForm", new Whale());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Whale? whale = context.Whales.Find(id);

            if (whale == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            return View("WhaleForm", whale);
        }

        [HttpPost]
        public IActionResult Edit(Whale whale)
        {
            if (ModelState.IsValid)
            {
                context.Whales.Update(whale);
                context.SaveChanges();
                return RedirectToAction("Detail", new { id = whale.Id });
            }
            else
            {
                ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
                return View("WhaleForm", whale);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Whales = context.Whales.OrderBy(w => w.CommonName).ToList();
            var whale = context.Whales.Find(id);
            return View("Delete", whale);
        }

        [HttpPost]
        public IActionResult Delete(Whale whale)
        {
            context.Whales.Remove(whale);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
