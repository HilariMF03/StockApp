using StockApp.Infrastructure.Persistence;
namespace StockApp

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuraci�n del contexto con cadena de conexi�n


            // Agrega servicios al contenedor
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //Aqu� registras 
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
