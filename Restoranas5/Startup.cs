using Microsoft.Extensions.Configuration;
using Restoranas5.Data;
using Microsoft.EntityFrameworkCore;
using Restoranas5.Models;
using Restoranas5.Services;

namespace Restoranas5
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddDbContext<ApplicationDbContext>(options =>
                           options.UseSqlServer(
                                                  Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddSession(); // Pridedama sesijos palaikymo eilutė
            //services.AddScoped<OrderedDishesListService>();
            services.AddControllersWithViews();
            // services.AddScoped<RestaurantService>();
            // register application services
            //services.AddScoped<IReservationService, ReservationService>();
            //services.AddScoped<ITableService, TableService>();
            //services.AddScoped<IMenuItem, MenuItemServices>();
            services.AddSingleton<IHttpContextAccessor,  HttpContextAccessor>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
           services.AddMemoryCache();
            services.AddSession();
            services.AddTransient<IMenuItem, MenuItemService>();

        }
        // Šis metodas yra skirtas konfigūruoti HTTP žiniatinklio programos siuntimo grandinę.
        // Išsamesnė informacija apie tai yra čia: https://go.microsoft.com/fwlink/?LinkID=398940

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession(); // Įjungti sesiją
            app.UseAuthorization();
            app.UseSession(); // Įjungti sesiją
            app.UseDeveloperExceptionPage();
            // Ši eilutė leidžia naudoti failus, esančius wwwroot kataloge.
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                                       name: "default", // Šis yra URL maršruto pavadinimas
                                                        pattern: "{controller=Home}/{action=Index}/{id?}"); // Tai yra URL maršruto šablonas
                                                                                                            //                               });
                                                                                                            //                                      })
            });
        }

    }
}
