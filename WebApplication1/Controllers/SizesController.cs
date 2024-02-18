using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Contexts;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class SizesController : Controller
    {
        private readonly DataContext db;

        public SizesController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            //var sizes = db.Set<Size>();
            var sizes = db.Sizes.ToList();
            return View(sizes);
        }

        public IActionResult Details(int id)
        {
            var size = db.Sizes.FirstOrDefault(m => m.Id == id);

            if(size == null)
                return NotFound();

            return View(size);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Size model)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Edit(Size model)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
