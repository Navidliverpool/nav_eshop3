namespace nav_eshop3.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItem(int productId, string productName, int quantity, decimal price)
        {
            var existingItem = Items.FirstOrDefault(item => item.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                var newItem = new CartItem
                {
                    ProductId = productId,
                    ProductName = productName,
                    Quantity = quantity,
                    Price = price
                };
                Items.Add(newItem);
            }
        }

        public void UpdateItemQuantity(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }

    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
