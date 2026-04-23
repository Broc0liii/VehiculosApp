using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace VehiculosMaui.ViewModels
{
    public partial class InicioViewModel : ObservableObject
    {
        public InicioViewModel()
        {
        }

        [RelayCommand]
        private async Task NavegarAVehiculosAsync()
        {
            await Shell.Current.GoToAsync("ListaVehiculosPage");
        }

        [RelayCommand]
        private async Task NavegarAMantenimientosAsync()
        {
            await Shell.Current.GoToAsync("HistorialMantenimientosPage");
        }

        [RelayCommand]
        private async Task NavegarAFallasAsync()
        {
            await Shell.Current.GoToAsync("VehiculosIncidenciasPage");
        }

        [RelayCommand]
        private async Task NavegarACatalogosAsync()
        {
            await Shell.Current.GoToAsync("CatalogosPage");
        }
    }
}
