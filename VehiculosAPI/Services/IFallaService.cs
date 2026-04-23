using VehiculosAPI.Entities;

namespace VehiculosAPI.Services
{
    public interface IFallaService
    {
        Task<List<Falla>> GetFallasByVehiculoAsync(int vehiculoId);
        Task<Falla> SetFallaAsync(Falla falla);
        Task<bool> DeleteFallaAsync(int id);
        Task<Falla> UpdateFallaAsync(Falla falla);
    }
}
