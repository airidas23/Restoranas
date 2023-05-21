namespace Restoranas5.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }  

        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public string PaymentMethodCarId { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
