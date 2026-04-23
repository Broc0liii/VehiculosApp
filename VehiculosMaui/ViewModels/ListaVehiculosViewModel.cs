using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehiculosMaui.Models;
using VehiculosMaui.Services;

namespace VehiculosMaui.ViewModels
{
    public partial class ListaVehiculosViewModel : ObservableObject
    {
        private readonly IApiService<Vehiculo> _apiService;

        [ObservableProperty]
        private ObservableCollection<Vehiculo> _vehiculos;

        [ObservableProperty]
        private bool _isBusy;

        public ListaVehiculosViewModel(IApiService<Vehiculo> apiService)
        {
            _apiService = apiService;
            Vehiculos = new ObservableCollection<Vehiculo>();
            LoadVehiculosCommand.Execute(null);
        }

        [RelayCommand]
        private async Task LoadVehiculosAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var vehiculos = await _apiService.GetAllAsync("api/Vehiculo");
                Vehiculos.Clear();
                if (vehiculos != null)
                {
                    foreach (var v in vehiculos)
                    {
                        Vehiculos.Add(v);
                    }
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"No se pudieron cargar los vehículos: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task NuevoVehiculoAsync()
        {
            await Shell.Current.GoToAsync("RegistrarVehiculoPage");
        }
    }
}
