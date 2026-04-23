using Microsoft.AspNetCore.Mvc;
using VehiculosAPI.Entities;
using VehiculosAPI.Services;

namespace VehiculosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MantenimientoController : ControllerBase
    {
        private readonly IMantenimientoService _mantenimientoService;

        public MantenimientoController(IMantenimientoService mantenimientoService)
        {
            _mantenimientoService = mantenimientoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mantenimiento>>> GetAll()
        {
            var mantenimientos = await _mantenimientoService.GetMantenimientosByVehiculoAsync(0);
            return Ok(mantenimientos);
        }

        [HttpGet("vehiculo/{vehiculoId}")]
        public async Task<ActionResult<List<Mantenimiento>>> GetByVehiculo(int vehiculoId)
        {
            var mantenimientos = await _mantenimientoService.GetMantenimientosByVehiculoAsync(vehiculoId);
            return Ok(mantenimientos);
        }

        [HttpPost]
        public async Task<ActionResult<Mantenimiento>> Post([FromBody] Mantenimiento mantenimiento)
        {
            var nuevoMantenimiento = await _mantenimientoService.SetMantenimientoAsync(mantenimiento);
            return Ok(nuevoMantenimiento);
        }

        [HttpPut]
        public async Task<ActionResult<Mantenimiento>> Put([FromBody] Mantenimiento mantenimiento)
        {
            var actualizado = await _mantenimientoService.UpdateMantenimientoAsync(mantenimiento);
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var eliminado = await _mantenimientoService.DeleteMantenimientoAsync(id);
            if (eliminado) return Ok();
            return BadRequest("No se pudo eliminar el mantenimiento");
        }
    }
}
