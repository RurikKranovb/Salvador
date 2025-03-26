
using Microsoft.EntityFrameworkCore;
using Salvador.DAL.Context;
using Salvador.UI.Infrastructure.Interface;
using Salvador.UI.Infrastructure.Service;

namespace Salvador.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var service = builder.Services;

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            service.AddDbContext<SalvadorDataBase>(opt =>
                opt.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddRazorPages();

            service.AddScoped<IRecordData, SqlRecordDate>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.UseEndpoints(endpoints =>
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"));


            app.Run();
        }
    }
}
