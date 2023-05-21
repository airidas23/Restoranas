namespace Restoranas5.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
       // public int Quantity { get; set; }

        public string ImageThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPreferred { get; set; }  // Add this
        //public bool InStock { get; set; }

    }
}
