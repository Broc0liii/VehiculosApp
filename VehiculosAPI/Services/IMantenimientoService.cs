using VehiculosAPI.Entities;

namespace VehiculosAPI.Services
{
    public interface IMantenimientoService
    {
        Task<List<Mantenimiento>> GetMantenimientosByVehiculoAsync(int vehiculoId);
        Task<Mantenimiento> SetMantenimientoAsync(Mantenimiento mantenimiento);
        Task<bool> DeleteMantenimientoAsync(int id);
        Task<Mantenimiento> UpdateMantenimientoAsync(Mantenimiento mantenimiento);
    }
}
