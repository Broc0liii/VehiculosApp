using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Data;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Services
{
    public class CatalogoService : ICatalogoService
    {
        private readonly ApplicationDbContext _context;

        public CatalogoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CatMarca>> GetMarcasAsync()
        {
            return await _context.CatMarcas.ToListAsync();
        }

        public async Task<CatMarca?> SetMarcaAsync(CatMarca marca)
        {
            _context.CatMarcas.Add(marca);
            await _context.SaveChangesAsync();
            return marca;
        }

        public async Task<CatMarca?> UpdateMarcaAsync(CatMarca marca)
        {
            var existing = await _context.CatMarcas.FindAsync(marca.Id);
            if (existing == null) return null;
            existing.Marca = marca.Marca;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteMarcaAsync(int id)
        {
            var existing = await _context.CatMarcas.FindAsync(id);
            if (existing == null) return false;
            _context.CatMarcas.Remove(existing);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<CatServicio>> GetServiciosAsync()
        {
            return await _context.CatServicios.ToListAsync();
        }

        public async Task<CatServicio?> SetServicioAsync(CatServicio servicio)
        {
            _context.CatServicios.Add(servicio);
            await _context.SaveChangesAsync();
            return servicio;
        }

        public async Task<CatServicio?> UpdateServicioAsync(CatServicio servicio)
        {
            var existing = await _context.CatServicios.FindAsync(servicio.Id);
            if (existing == null) return null;
            existing.Servicio = servicio.Servicio;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteServicioAsync(int id)
        {
            var existing = await _context.CatServicios.FindAsync(id);
            if (existing == null) return false;
            _context.CatServicios.Remove(existing);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<CatEstatusFalla>> GetEstatusFallasAsync()
        {
            return await _context.CatEstatusFallas.ToListAsync();
        }

        public async Task<CatEstatusFalla?> SetEstatusFallaAsync(CatEstatusFalla estatus)
        {
            _context.CatEstatusFallas.Add(estatus);
            await _context.SaveChangesAsync();
            return estatus;
        }

        public async Task<CatEstatusFalla?> UpdateEstatusFallaAsync(CatEstatusFalla estatus)
        {
            var existing = await _context.CatEstatusFallas.FindAsync(estatus.Id);
            if (existing == null) return null;
            existing.Estatus = estatus.Estatus;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteEstatusFallaAsync(int id)
        {
            var existing = await _context.CatEstatusFallas.FindAsync(id);
            if (existing == null) return false;
            _context.CatEstatusFallas.Remove(existing);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
