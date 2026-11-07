
using Microsoft.AspNetCore.Mvc;
using Project_MVC_BikeShop.Data;

namespace Project_MVC_BikeShop.Controllers
{
    public class BikeCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BikeCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.BikeCategories.ToList();

            return View(categories);
        }
    }
}
