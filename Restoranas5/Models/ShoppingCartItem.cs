using System.IO.Pipelines;

namespace Restoranas5.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public MenuItem MenuItems  { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
