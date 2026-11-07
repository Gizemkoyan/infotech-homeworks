
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC_CafeMenu.Data;
using Project_MVC_CafeMenu.Models;

namespace Project_MVC_CafeMenu.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly AppDbContext _context;

        public MenuItemController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            var menuItems = _context.MenuItems
                .Include(m => m.MenuCategory)
                .AsQueryable();

            if (categoryId.HasValue)
            {
                menuItems = menuItems.Where(
                    m => m.MenuCategoryId == categoryId.Value);
            }

            return View(menuItems.ToList());
        }
        
        public IActionResult Details(int id)
        {
            var menuItem = _context.MenuItems
                .Include(m => m.MenuCategory)
                .FirstOrDefault(m => m.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return View(menuItem);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var menuItem = _context.MenuItems.Find(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.MenuCategories.ToList();

            return View(menuItem);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuItem menuItem)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.MenuCategories.ToList();
                return View(menuItem);
            }

            var existingMenuItem = _context.MenuItems.Find(menuItem.Id);

            if (existingMenuItem == null)
            {
                return NotFound();
            }

            existingMenuItem.Name = menuItem.Name;
            existingMenuItem.Description = menuItem.Description;
            existingMenuItem.Price = menuItem.Price;
            existingMenuItem.IsAvailable = menuItem.IsAvailable;
            existingMenuItem.PreparationTimeMinutes = menuItem.PreparationTimeMinutes;
            existingMenuItem.ImageUrl = menuItem.ImageUrl;
            existingMenuItem.MenuCategoryId = menuItem.MenuCategoryId;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
