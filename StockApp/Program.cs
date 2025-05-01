using StockApp.Infrastructure.Persistence;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configuración de infraestructura y servicios
        builder.Services.AddPersistenceInfrastructure(builder.Configuration);
        builder.Services.AddApplicationLayer(builder.Configuration);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configura el pipeline HTTP
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
