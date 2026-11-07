using Microsoft.AspNetCore.Mvc;
using Project_MVC_PlantShop.Data;
using Project_MVC_PlantShop.Models;

namespace Project_MVC_PlantShop.Controllers
{
    public class PlantController : Controller
    {
        private readonly AppDbContext _context;

        public PlantController()
        {
            _context = new AppDbContext();
        }

        public IActionResult Index()
        {
            var plants = _context.Plants.ToList();
            return View(plants);
        }

        public IActionResult Details(int id)
        {
            var plant = _context.Plants.Find(id);

            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        public IActionResult Edit(int id)
        {
            var plant = _context.Plants.Find(id);

            if (plant == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.PlantCategories.ToList();

            return View(plant);
        }

        [HttpPost]
        public IActionResult Edit(Plant plant)
        {
            _context.Plants.Update(plant);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}