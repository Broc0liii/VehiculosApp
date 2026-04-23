using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class VehiculosIncidenciasPage : ContentPage
    {
        public VehiculosIncidenciasPage(FallasViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is FallasViewModel vm)
            {
                vm.LoadFallasCommand.Execute(null);
            }
        }
    }
}