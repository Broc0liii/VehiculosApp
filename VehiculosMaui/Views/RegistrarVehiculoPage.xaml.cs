using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class RegistrarVehiculoPage : ContentPage
    {
        public RegistrarVehiculoPage(RegistrarVehiculoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
