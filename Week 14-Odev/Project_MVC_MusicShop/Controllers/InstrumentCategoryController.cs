using Microsoft.AspNetCore.Mvc;
using Project_MVC_MusicShop.Data;
using System.Linq;

namespace Project_MVC_MusicShop.Controllers
{
    public class InstrumentCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public InstrumentCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.InstrumentCategories.ToList();

            return View(categories);
        }
    }
}