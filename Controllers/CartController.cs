using Microsoft.AspNetCore.Mvc;
using System.Linq;
using nav_eshop3.Models;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

namespace nav_eshop3.Controllers
{
    //[Authorize]
    public class CartController : Controller
    {
        // Other actions
        public IActionResult Index()
        {
            var cart = GetCartFromCookie();
            return View(cart.Items);
        }

        public IActionResult AddToCart(int productId, string productName, int quantity, decimal price)
        {
            var cart = GetCartFromCookie() ?? new Cart();
            cart.AddItem(productId, productName, quantity, price);
            SaveCartToCookie(cart);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCartItem(int productId, int quantity)
        {
            var cart = GetCartFromCookie();
            if (cart != null)
            {
                cart.UpdateItemQuantity(productId, quantity);
                SaveCartToCookie(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCartItem(int productId)
        {
            var cart = GetCartFromCookie();
            if (cart != null)
            {
                cart.RemoveItem(productId);
                SaveCartToCookie(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ClearCart()
        {
            ClearCartCookie();
            return RedirectToAction("Index");
        }

        private Cart GetCartFromCookie()
        {
            var cartCookieValue = Request.Cookies["Cart"];
            if (!string.IsNullOrEmpty(cartCookieValue))
            {
                var cartJson = Encoding.UTF8.GetString(Convert.FromBase64String(cartCookieValue));
                return JsonSerializer.Deserialize<Cart>(cartJson);
            }
            return null;
        }

        private void SaveCartToCookie(Cart cart)
        {
            var cartJson = JsonSerializer.Serialize(cart);
            var cartCookieValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(cartJson));
            Response.Cookies.Append("Cart", cartCookieValue, new CookieOptions
            {
                SameSite = SameSiteMode.Strict,
                Expires = DateTimeOffset.Now.AddDays(7)
            });
        }

        private void ClearCartCookie()
        {
            Response.Cookies.Delete("Cart");
        }
    }


}
