
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC_BikeShop.Data;
using Project_MVC_BikeShop.Models;

namespace Project_MVC_BikeShop.Controllers
{
    public class BikeController : Controller
    {
        private readonly AppDbContext _context;

        public BikeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            var bikes = _context.Bikes
                .Include(b => b.BikeCategory)
                .AsQueryable();

            if (categoryId.HasValue)
            {
                bikes = bikes.Where(
                    b => b.BikeCategoryId == categoryId.Value
                );
            }

            return View(bikes.ToList());
        }
        
        public IActionResult Details(int id)
        {
            var bike = _context.Bikes
                .Include(b => b.BikeCategory)
                .FirstOrDefault(b => b.Id == id);

            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bike = _context.Bikes.Find(id);

            if (bike == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.BikeCategories.ToList();

            return View(bike);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Bike bike)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.BikeCategories.ToList();
                return View(bike);
            }

            var existingBike = _context.Bikes.Find(bike.Id);

            if (existingBike == null)
            {
                return NotFound();
            }

            existingBike.Name = bike.Name;
            existingBike.Description = bike.Description;
            existingBike.Price = bike.Price;
            existingBike.StockQuantity = bike.StockQuantity;
            existingBike.FrameSize = bike.FrameSize;
            existingBike.ImageUrl = bike.ImageUrl;
            existingBike.BikeCategoryId = bike.BikeCategoryId;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}
