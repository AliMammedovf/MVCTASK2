using Microsoft.EntityFrameworkCore;
using MVCtask.DAL;

namespace MVCtask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
           


            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-IVL046S\\SQLEXPRESS;Database=MVCTASK;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;");
            });

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}");
            

            app.Run();
        }
    }
}
