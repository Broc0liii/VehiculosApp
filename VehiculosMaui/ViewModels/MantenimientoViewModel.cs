using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehiculosMaui.Models;
using VehiculosMaui.Services;

namespace VehiculosMaui.ViewModels
{
    public partial class MantenimientoViewModel : ObservableObject
    {
        private readonly IApiService<Mantenimiento> _apiService;

        [ObservableProperty]
        private ObservableCollection<Mantenimiento> _mantenimientos;

        [ObservableProperty]
        private bool _isBusy;

        public MantenimientoViewModel(IApiService<Mantenimiento> apiService)
        {
            _apiService = apiService;
            Mantenimientos = new ObservableCollection<Mantenimiento>();
            LoadMantenimientosCommand.Execute(null);
        }

        [RelayCommand]
        private async Task LoadMantenimientosAsync()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var mants = await _apiService.GetAllAsync("api/Mantenimiento");
                Mantenimientos.Clear();
                if (mants != null)
                {
                    foreach (var m in mants) Mantenimientos.Add(m);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"No se pudo cargar mantenimientos: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task NuevoMantenimientoAsync()
        {
            await Shell.Current.GoToAsync("RegistrarMantenimientoPage");
        }
    }
}
