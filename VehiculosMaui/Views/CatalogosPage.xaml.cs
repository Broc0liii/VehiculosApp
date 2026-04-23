using Microsoft.Maui.Controls;
using VehiculosMaui.ViewModels;

namespace VehiculosMaui.Views
{
    public partial class CatalogosPage : ContentPage
    {
        public CatalogosPage(CatalogosViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is CatalogosViewModel vm)
            {
                vm.LoadDataCommand.Execute(null);
            }
        }
    }
}