using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class RegistrarMantenimientoPage : ContentPage
    {
        public RegistrarMantenimientoPage(MantenimientoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}