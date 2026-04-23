using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehiculosMaui.Models;
using VehiculosMaui.Services;

namespace VehiculosMaui.ViewModels
{
    public partial class FallasViewModel : ObservableObject
    {
        private readonly IApiService<Falla> _apiService;

        [ObservableProperty]
        private ObservableCollection<Falla> _fallas;

        [ObservableProperty]
        private bool _isBusy;

        public FallasViewModel(IApiService<Falla> apiService)
        {
            _apiService = apiService;
            Fallas = new ObservableCollection<Falla>();
            LoadFallasCommand.Execute(null);
        }

        [RelayCommand]
        private async Task LoadFallasAsync()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var fallasData = await _apiService.GetAllAsync("api/Falla");
                Fallas.Clear();
                if (fallasData != null)
                {
                    foreach (var f in fallasData) Fallas.Add(f);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"No se pudieron cargar fallas: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task ReportarFallaAsync()
        {
            await Shell.Current.GoToAsync("ReporteFallaPage");
        }
    }
}
