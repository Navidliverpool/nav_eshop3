using nav_eshop3.Models;

namespace nav_eshop3.ViewModels
{
    public class HomeVM
    {
        public string? Keyword { get; set; }
        public List<Category> AllCategories { get; set; }
    }
}
