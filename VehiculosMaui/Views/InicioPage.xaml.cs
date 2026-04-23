using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class InicioPage : ContentPage
    {
        public InicioPage(InicioViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
