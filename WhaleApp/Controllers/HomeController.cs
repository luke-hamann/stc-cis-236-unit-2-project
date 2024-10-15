//
// Title: Home Controller
// Purpose: This controller provides all the routing of the application,
//          including the index page, detail page, add page, edit page, and
//          delete page. It also provides a constructor parameter for recieving
//          a whale database context and accessing the whale database.
//

using Microsoft.AspNetCore.Mvc;
using WhaleApp.Models;

namespace WhaleApp.Controllers
{
    public class HomeController : Controller
    {
        private WhaleContext context { get; set; }

        public HomeController(WhaleContext context)
        {
            this.context = context;
        }

        private List<Whale> GetAllWhales()
        {
            return context.Whales.OrderBy(w => w.CommonName!.ToLower()).ToList();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Whales = GetAllWhales();
            return View(ViewBag.Whales);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var whale = context.Whales.Find(id);

            if (whale == null)
            {
                return NotFound();
            }

            ViewBag.Whales = GetAllWhales();
            return View("Detail", whale);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Whales = GetAllWhales();
            return View("WhaleForm", new Whale());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var whale = context.Whales.Find(id);

            if (whale == null)
            {
                return NotFound();
            }

            ViewBag.Whales = GetAllWhales();
            return View("WhaleForm", whale);
        }

        [HttpPost]
        public IActionResult Edit(Whale whale)
        {
            if (ModelState.IsValid)
            {
                if (whale.Id == 0)
                {
                    context.Whales.Add(whale);
                }
                else
                {
                    context.Whales.Update(whale);
                }

                context.SaveChanges();
                return RedirectToAction("Detail", new { id = whale.Id, slug = whale.Slug });
            }
            else
            {
                ViewBag.Whales = GetAllWhales();
                return View("WhaleForm", whale);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var whale = context.Whales.Find(id);

            if (whale == null)
            {
                return NotFound();
            }

            ViewBag.Whales = GetAllWhales();
            return View("Delete", whale);
        }

        [HttpPost]
        public IActionResult Delete(Whale whale)
        {
            context.Whales.Remove(whale);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
