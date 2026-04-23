using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Services
{
    public interface ICatalogoService
    {
        Task<List<CatMarca>> GetMarcasAsync();
        Task<CatMarca?> SetMarcaAsync(CatMarca marca);
        Task<CatMarca?> UpdateMarcaAsync(CatMarca marca);
        Task<bool> DeleteMarcaAsync(int id);

        Task<List<CatServicio>> GetServiciosAsync();
        Task<CatServicio?> SetServicioAsync(CatServicio servicio);
        Task<CatServicio?> UpdateServicioAsync(CatServicio servicio);
        Task<bool> DeleteServicioAsync(int id);

        Task<List<CatEstatusFalla>> GetEstatusFallasAsync();
        Task<CatEstatusFalla?> SetEstatusFallaAsync(CatEstatusFalla estatus);
        Task<CatEstatusFalla?> UpdateEstatusFallaAsync(CatEstatusFalla estatus);
        Task<bool> DeleteEstatusFallaAsync(int id);
    }
}
