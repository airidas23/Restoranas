using Microsoft.EntityFrameworkCore;
using Restoranas5.Models;
using System.IO.Pipelines;

namespace Restoranas5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Order> Order { get; set; }
       public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            //modelBuilder.Entity<Dish>().ToTable("Dish");
            //modelBuilder.Entity<Reservation>().ToTable("Reservation");


        //    modelBuilder.Entity<MenuItem>()
        //        .Property(b => b.Price)
        //        .HasPrecision(18, 2);
        //    modelBuilder.Entity<MenuItem>().HasData(
        //new {Id = 1, Name = "Apple Pie", Price = 12.95M, Description = "Our famous apple pies!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsPreferred = true,  ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" },
        //new {Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, Description = "You'll love it!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", IsPreferred = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg" }

       

       //);

        }
    }
}
