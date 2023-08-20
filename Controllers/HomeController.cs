using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using nav_eshop3.Data;
using nav_eshop3.Models;
using nav_eshop3.ViewModels;
using System.Diagnostics;

namespace nav_eshop3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeVM();
            var allCategory = _context.Categories.ToList();

            homeVM.AllCategories = allCategory;
            return View(homeVM);
        }

        [HttpGet]
        public IActionResult Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return RedirectToAction("Index", "Home");
            }
            var searchedProductByName = _context.Products
                  .Where(p => p.Name.Contains(keyword))
                  .Select(p => new ProductVM
                  {
                      Name = p.Name,
                      Brand = p.Brand,
                      Price = p.Price,
                      CategoryId = p.CategoryId
                  })
                  .ToList();
            return View(searchedProductByName);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}