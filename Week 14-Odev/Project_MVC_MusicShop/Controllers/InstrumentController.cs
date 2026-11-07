using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC_MusicShop.Data;
using Project_MVC_MusicShop.Models;

namespace Project_MVC_MusicShop.Controllers
{
    public class InstrumentController : Controller
    {
        private readonly AppDbContext _context;

        public InstrumentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            var instruments = _context.Instruments
                .Include(i => i.InstrumentCategory)
                .AsQueryable();

            if (categoryId.HasValue)
            {
                instruments = instruments.Where(
                    i => i.InstrumentCategoryId == categoryId.Value
                );
            }

            return View(instruments.ToList());
        }
        public IActionResult Details(int id)
        {
            var instrument = _context.Instruments.Find(id);

            if (instrument == null)
            {
                return NotFound();
            }

            return View(instrument);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var instrument = _context.Instruments.Find(id);

            if (instrument == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.InstrumentCategories.ToList();

            return View(instrument);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instrument instrument)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.InstrumentCategories.ToList();
                return View(instrument);
            }

            var existingInstrument = _context.Instruments.Find(instrument.Id);

            if (existingInstrument == null)
            {
                return NotFound();
            }

            existingInstrument.Name = instrument.Name;
            existingInstrument.Description = instrument.Description;
            existingInstrument.Brand = instrument.Brand;
            existingInstrument.Price = instrument.Price;
            existingInstrument.StockQuantity = instrument.StockQuantity;
            existingInstrument.ImageUrl = instrument.ImageUrl;
            existingInstrument.InstrumentCategoryId = instrument.InstrumentCategoryId;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}