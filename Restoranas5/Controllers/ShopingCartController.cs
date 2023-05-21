using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoranas5.Models;
using Restoranas5.Models.ViewModels;
using Restoranas5.Services;

namespace Restoranas5.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMenuItem _menuItemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMenuItem menuItemRepository, ShoppingCart shoppingCart)
        {
            _menuItemRepository = menuItemRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var selectedItem = _menuItemRepository.MenuItems.FirstOrDefault(p => p.Id == id);

            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedItem = _menuItemRepository.MenuItems.FirstOrDefault(p => p.Id == id);

            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }
    }


}
