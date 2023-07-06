namespace nav_eshop3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
