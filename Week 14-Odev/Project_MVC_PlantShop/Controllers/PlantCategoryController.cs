using Microsoft.AspNetCore.Mvc;
using Project_MVC_PlantShop.Data;

namespace Project_MVC_PlantShop.Controllers
{
    public class PlantCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public PlantCategoryController()
        {
            _context = new AppDbContext();
        }

        public IActionResult Index()
        {
            var categories=_context.PlantCategories.ToList();
            return View(categories);
        }
    }
}