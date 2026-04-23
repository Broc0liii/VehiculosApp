namespace VehiculosMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("RegistrarVehiculoPage", typeof(Views.RegistrarVehiculoPage));
            Routing.RegisterRoute("DetalleVehiculoPage", typeof(Views.DetalleVehiculoPage));
            Routing.RegisterRoute("RegistrarMantenimientoPage", typeof(Views.RegistrarMantenimientoPage));
            Routing.RegisterRoute("ListaVehiculosPage", typeof(Views.ListaVehiculosPage));
            Routing.RegisterRoute("HistorialMantenimientosPage", typeof(Views.HistorialMantenimientosPage));
            Routing.RegisterRoute("VehiculosIncidenciasPage", typeof(Views.VehiculosIncidenciasPage));
            Routing.RegisterRoute("CatalogosPage", typeof(Views.CatalogosPage));
        }
    }
}
