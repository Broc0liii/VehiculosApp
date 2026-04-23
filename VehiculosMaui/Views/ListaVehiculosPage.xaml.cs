using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class ListaVehiculosPage : ContentPage
    {
        public ListaVehiculosPage(ListaVehiculosViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is ListaVehiculosViewModel vm)
            {
                vm.LoadVehiculosCommand.Execute(null);
            }
        }
    }
}