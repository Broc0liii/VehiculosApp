using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehiculosMaui.Models;
using VehiculosMaui.Services;

namespace VehiculosMaui.ViewModels
{
    public partial class CatalogosViewModel : ObservableObject
    {
        private readonly IApiService<CatMarca> _marcaService;
        private readonly IApiService<CatServicio> _servicioService;
        private readonly IApiService<CatEstatusFalla> _estatusService;

        [ObservableProperty]
        private ObservableCollection<CatMarca> _marcas;

        [ObservableProperty]
        private ObservableCollection<CatServicio> _servicios;

        [ObservableProperty]
        private ObservableCollection<CatEstatusFalla> _estatusFallas;

        [ObservableProperty]
        private bool _isBusy;

        public CatalogosViewModel(
            IApiService<CatMarca> marcaService,
            IApiService<CatServicio> servicioService,
            IApiService<CatEstatusFalla> estatusService)
        {
            _marcaService = marcaService;
            _servicioService = servicioService;
            _estatusService = estatusService;

            Marcas = new ObservableCollection<CatMarca>();
            Servicios = new ObservableCollection<CatServicio>();
            EstatusFallas = new ObservableCollection<CatEstatusFalla>();

            LoadDataCommand.Execute(null);
        }

        [RelayCommand]
        private async Task LoadDataAsync()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var marcas = await _marcaService.GetAllAsync("api/Catalogo/Marcas");
                var servicios = await _servicioService.GetAllAsync("api/Catalogo/Servicios");
                var estatus = await _estatusService.GetAllAsync("api/Catalogo/EstatusFalla");

                Marcas.Clear();
                Servicios.Clear();
                EstatusFallas.Clear();

                if (marcas != null) foreach (var m in marcas) Marcas.Add(m);
                if (servicios != null) foreach (var s in servicios) Servicios.Add(s);
                if (estatus != null) foreach (var e in estatus) EstatusFallas.Add(e);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Error al cargar catálogos: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
