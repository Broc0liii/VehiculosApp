using System;

namespace VehiculosMaui.Models
{
    public class Falla
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }
        public DateTime FechaReporte { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int CatEstatusFallaId { get; set; }
        public CatEstatusFalla? CatEstatusFalla { get; set; }
        public bool EsCritica { get; set; }
    }
}
