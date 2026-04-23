using Microsoft.Extensions.Logging;

namespace VehiculosMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // HTTP Client
            // TODO: Change this to your actual API URL when running on Android/iOS (e.g., 10.0.2.2 or a tunneling service)
            string apiBaseUrl = "https://localhost:7121/"; 
            builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri(apiBaseUrl));
            
            // Services
            builder.Services.AddScoped(typeof(VehiculosMaui.Services.IApiService<>), typeof(VehiculosMaui.Services.ApiService<>));
            
            // ViewModels
            builder.Services.AddTransient<VehiculosMaui.ViewModels.InicioViewModel>();
            builder.Services.AddTransient<VehiculosMaui.ViewModels.ListaVehiculosViewModel>();
            builder.Services.AddTransient<VehiculosMaui.ViewModels.RegistrarVehiculoViewModel>();
            builder.Services.AddTransient<VehiculosMaui.ViewModels.CatalogosViewModel>();
            builder.Services.AddTransient<VehiculosMaui.ViewModels.MantenimientoViewModel>();
            builder.Services.AddTransient<VehiculosMaui.ViewModels.FallasViewModel>();
            
            // Views
            builder.Services.AddTransient<VehiculosMaui.Views.InicioPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.ListaVehiculosPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.RegistrarVehiculoPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.CatalogosPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.HistorialMantenimientosPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.RegistrarMantenimientoPage>();
            builder.Services.AddTransient<VehiculosMaui.Views.VehiculosIncidenciasPage>();

            return builder.Build();
        }
    }
}
