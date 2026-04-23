using Microsoft.AspNetCore.Mvc;
using VehiculosAPI.Entities;
using VehiculosAPI.Services;

namespace VehiculosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FallaController : ControllerBase
    {
        private readonly IFallaService _fallaService;

        public FallaController(IFallaService fallaService)
        {
            _fallaService = fallaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Falla>>> GetAll()
        {
            var fallas = await _fallaService.GetFallasByVehiculoAsync(0);
            return Ok(fallas);
        }

        [HttpGet("vehiculo/{vehiculoId}")]
        public async Task<ActionResult<List<Falla>>> GetByVehiculo(int vehiculoId)
        {
            var fallas = await _fallaService.GetFallasByVehiculoAsync(vehiculoId);
            return Ok(fallas);
        }

        [HttpPost]
        public async Task<ActionResult<Falla>> Post([FromBody] Falla falla)
        {
            var nuevaFalla = await _fallaService.SetFallaAsync(falla);
            return Ok(nuevaFalla);
        }

        [HttpPut]
        public async Task<ActionResult<Falla>> Put([FromBody] Falla falla)
        {
            var actualizado = await _fallaService.UpdateFallaAsync(falla);
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var eliminado = await _fallaService.DeleteFallaAsync(id);
            if (eliminado) return Ok();
            return BadRequest("No se pudo eliminar la falla");
        }
    }
}
