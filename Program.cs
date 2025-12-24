using Microsoft.EntityFrameworkCore;

namespace Front_to_Back
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DAL.AppDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS03;Database=FronttoBackDb;Trusted_Connection=true;Encrypt=false");
            });
            var app = builder.Build();

            app.UseStaticFiles();
           
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}"
               );
            app.Run();
        }
    }
}
