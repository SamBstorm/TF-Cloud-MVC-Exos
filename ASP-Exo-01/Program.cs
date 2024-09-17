namespace ASP_Exo_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            /*
            app.MapControllerRoute(
                name: "mathAdd01",
                pattern: "/Math/Addition/{nb1}/{nb2}",
                defaults: new { controller = "Math", action = "Addition"}
                );

            app.MapControllerRoute(
                name: "mathAdd02",
                pattern: "/Math/{nb1}/Plus/{nb2}",
                defaults: new { controller = "Math", action = "Addition" }
                );*/

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
