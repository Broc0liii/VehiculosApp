using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Data;
using VehiculosAPI.Entities;

namespace VehiculosAPI.Services
{
    public class FallaService : IFallaService
    {
        private readonly ApplicationDbContext _context;

        public FallaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Falla>> GetFallasByVehiculoAsync(int vehiculoId)
        {
            var query = _context.Fallas
                .Include(f => f.CatEstatusFalla)
                .Include(f => f.Vehiculo)
                .AsQueryable();

            if (vehiculoId > 0)
            {
                query = query.Where(f => f.VehiculoId == vehiculoId);
            }
            return await query.ToListAsync();
        }

        public async Task<Falla> SetFallaAsync(Falla falla)
        {
            _context.Fallas.Add(falla);
            await _context.SaveChangesAsync();
            return falla;
        }

        public async Task<bool> DeleteFallaAsync(int id)
        {
            var falla = await _context.Fallas.FindAsync(id);
            if (falla == null) return false;

            _context.Fallas.Remove(falla);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Falla> UpdateFallaAsync(Falla falla)
        {
            _context.Fallas.Update(falla);
            await _context.SaveChangesAsync();
            return falla;
        }
    }
}
