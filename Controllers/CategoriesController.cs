using Microsoft.AspNetCore.Mvc;
using nav_eshop3.Data;
using nav_eshop3.Models;

namespace nav_eshop3.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Id)
        {
            var ProductsBelongToTheCategory = _context.Products.Where(p => p.Category.Name == Id).ToList();
            return View(ProductsBelongToTheCategory);
        }

    }
}
