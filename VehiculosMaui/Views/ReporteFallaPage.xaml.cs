using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class ReporteFallaPage : ContentPage
    {
        public ReporteFallaPage(FallasViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}