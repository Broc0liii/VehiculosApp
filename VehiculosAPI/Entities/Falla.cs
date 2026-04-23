using System;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Entities
{
    public class Falla
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }

        public DateTime FechaReporte { get; set; }
        public string Descripcion { get; set; }

        public int CatEstatusFallaId { get; set; }
        public CatEstatusFalla? CatEstatusFalla { get; set; }

        public bool EsCritica { get; set; }
    }
}
