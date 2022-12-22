using PieShop.Core.Models;
using System.Collections.Generic;

namespace PieShop.Core.Repository
{
    public class ShoppingCartRepository
    {
        private static ShoppingCart _shoppingCart = new ShoppingCart();
        public void AddToShoppingCart(Pie pie, int amount)
        {
            var shoppingCartItem = new ShoppingCartItem
            {
                Pie = pie,
                Amount = amount
            };

            _shoppingCart.CartItems.Add(shoppingCartItem);  
        }

        public List<ShoppingCartItem> GetAllShoppingCartItems()
        {
            return _shoppingCart.CartItems;
        }
    }
}
