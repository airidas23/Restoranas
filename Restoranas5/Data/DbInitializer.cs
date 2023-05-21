using Restoranas5.Models;

namespace Restoranas5.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.MenuItem.Any())
            {
                context.AddRange
                    (

                    new MenuItem { Id = 1, Name = "Apple Pie", Price = 12.95M, Description = "Our famous apple pies!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsPreferred = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" }
                    );
            }
            context.SaveChanges();
        }


    }
}
