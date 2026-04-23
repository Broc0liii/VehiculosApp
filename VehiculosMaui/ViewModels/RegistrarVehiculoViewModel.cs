using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehiculosMaui.Models;
using VehiculosMaui.Services;

namespace VehiculosMaui.ViewModels
{
    public partial class RegistrarVehiculoViewModel : ObservableObject
    {
        private readonly IApiService<Vehiculo> _apiService;

        [ObservableProperty]
        private string _placas = "";

        [ObservableProperty]
        private int _marcaId = 1;

        [ObservableProperty]
        private string _modelo = "";

        [ObservableProperty]
        private string _year = DateTime.Now.Year.ToString();

        [ObservableProperty]
        private bool _isBusy;

        public RegistrarVehiculoViewModel(IApiService<Vehiculo> apiService)
        {
            _apiService = apiService;
        }

        [RelayCommand]
        private async Task GuardarAsync()
        {
            if (string.IsNullOrWhiteSpace(Placas) || string.IsNullOrWhiteSpace(Modelo))
            {
                await Shell.Current.DisplayAlertAsync("Error", "Por favor completa los campos requeridos (Placas, Modelo).", "OK");
                return;
            }

            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var nuevoVehiculo = new Vehiculo
                {
                    Placas = Placas,
                    MarcaId = MarcaId,
                    Modelo = Modelo,
                    Year = Year
                };

                var result = await _apiService.CreateAsync("api/Vehiculo", nuevoVehiculo);
                if (result != null)
                {
                    await Shell.Current.DisplayAlertAsync("Éxito", "Vehículo registrado correctamente.", "OK");
                    await Shell.Current.GoToAsync("..");
                }
                else
                {
                    await Shell.Current.DisplayAlertAsync("Error", "No se pudo registrar el vehículo.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task CancelarAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
