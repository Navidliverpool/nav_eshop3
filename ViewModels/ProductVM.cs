using nav_eshop3.Models;

namespace nav_eshop3.ViewModels
{
    public class ProductVM
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
