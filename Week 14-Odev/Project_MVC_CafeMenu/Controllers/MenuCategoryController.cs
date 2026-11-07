
using Microsoft.AspNetCore.Mvc;
using Project_MVC_CafeMenu.Data;

namespace Project_MVC_CafeMenu.Controllers
{
    public class MenuCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public MenuCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.MenuCategories.ToList();

            return View(categories);
        }
    }
}
