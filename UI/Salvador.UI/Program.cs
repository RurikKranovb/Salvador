using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;
using Salvador.Interface.Services;
using Salvador.Logger;
using Salvador.Service;

namespace Salvador.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var service = builder.Services;

            // Add services to the container.
            service.AddRazorPages();

            service.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region DataBase

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            service.AddDbContext<DataBase>(opt =>
                opt.UseSqlServer(connectionString));

            service.AddTransient<DataBase>(); 
            #endregion

            service.AddScoped<IRecordService, RecordService>();

            var app = builder.Build();
            var configuration = app.Configuration;

            using (var scope = app.Services.CreateScope())
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILoggerFactory>();

                logger.AddLog4Net();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.UseRouting();

            app.MapRazorPages();

            app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
