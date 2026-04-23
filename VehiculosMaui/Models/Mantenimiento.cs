using System;

namespace VehiculosMaui.Models
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }
        public DateTime FechaServicio { get; set; }
        public int CatServicioId { get; set; }
        public CatServicio? CatServicio { get; set; }
        public decimal Costo { get; set; }
        public int KilometrajeActual { get; set; }
    }
}
