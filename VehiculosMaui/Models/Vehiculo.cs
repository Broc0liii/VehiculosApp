namespace VehiculosMaui.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public CatMarca? Marca { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Placas { get; set; } = string.Empty;
    }
}
