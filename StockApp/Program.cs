using StockApp.Infrastructure.Persistence;
namespace StockApp

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuración del contexto con cadena de conexión


            // Agrega servicios al contenedor
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //Aquí registras 
            builder.Services.AddPersistenceInfrastructure(builder.Configuration);
            builder.Services.AddApplicationLayer(builder.Configuration);


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
}
