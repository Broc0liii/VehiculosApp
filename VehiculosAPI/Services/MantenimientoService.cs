using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Data;
using VehiculosAPI.Entities;

namespace VehiculosAPI.Services
{
    public class MantenimientoService : IMantenimientoService
    {
        private readonly ApplicationDbContext _context;

        public MantenimientoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mantenimiento>> GetMantenimientosByVehiculoAsync(int vehiculoId)
        {
            var query = _context.Mantenimientos.Include(m => m.CatServicio).AsQueryable();
            if (vehiculoId > 0)
            {
                query = query.Where(m => m.VehiculoId == vehiculoId);
            }
            return await query.ToListAsync();
        }

        public async Task<Mantenimiento> SetMantenimientoAsync(Mantenimiento mantenimiento)
        {
            _context.Mantenimientos.Add(mantenimiento);
            await _context.SaveChangesAsync();
            return mantenimiento;
        }

        public async Task<bool> DeleteMantenimientoAsync(int id)
        {
            var mantenimiento = await _context.Mantenimientos.FindAsync(id);
            if (mantenimiento == null) return false;

            _context.Mantenimientos.Remove(mantenimiento);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Mantenimiento> UpdateMantenimientoAsync(Mantenimiento mantenimiento)
        {
            _context.Mantenimientos.Update(mantenimiento);
            await _context.SaveChangesAsync();
            return mantenimiento;
        }
    }
}
