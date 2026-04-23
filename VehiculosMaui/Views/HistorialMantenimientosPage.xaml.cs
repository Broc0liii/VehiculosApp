using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class HistorialMantenimientosPage : ContentPage
    {
        public HistorialMantenimientosPage(MantenimientoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is MantenimientoViewModel vm)
            {
                vm.LoadMantenimientosCommand.Execute(null);
            }
        }
    }
}