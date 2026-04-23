using Microsoft.AspNetCore.Mvc;
using VehiculosAPI.Entities.Catalogos;
using VehiculosAPI.Services;

namespace VehiculosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoController : ControllerBase
    {
        private readonly ICatalogoService _catalogoService;

        public CatalogoController(ICatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpGet("marcas")]
        public async Task<ActionResult<List<CatMarca>>> GetMarcas()
        {
            var marcas = await _catalogoService.GetMarcasAsync();
            return Ok(marcas);
        }

        [HttpPost("marcas")]
        public async Task<ActionResult<CatMarca>> SetMarca([FromBody] CatMarca marca)
        {
            var nuevaMarca = await _catalogoService.SetMarcaAsync(marca);
            return Ok(nuevaMarca);
        }

        [HttpPut("marcas")]
        public async Task<ActionResult<CatMarca>> UpdateMarca([FromBody] CatMarca marca)
        {
            var actualizado = await _catalogoService.UpdateMarcaAsync(marca);
            if (actualizado == null) return NotFound();
            return Ok(actualizado);
        }

        [HttpDelete("marcas/{id}")]
        public async Task<ActionResult> DeleteMarca(int id)
        {
            var eliminado = await _catalogoService.DeleteMarcaAsync(id);
            if (eliminado) return Ok();
            return BadRequest("No se pudo eliminar la marca");
        }

        [HttpGet("servicios")]
        public async Task<ActionResult<List<CatServicio>>> GetServicios()
        {
            var servicios = await _catalogoService.GetServiciosAsync();
            return Ok(servicios);
        }

        [HttpPost("servicios")]
        public async Task<ActionResult<CatServicio>> SetServicio([FromBody] CatServicio servicio)
        {
            var nuevoServicio = await _catalogoService.SetServicioAsync(servicio);
            return Ok(nuevoServicio);
        }

        [HttpPut("servicios")]
        public async Task<ActionResult<CatServicio>> UpdateServicio([FromBody] CatServicio servicio)
        {
            var actualizado = await _catalogoService.UpdateServicioAsync(servicio);
            if (actualizado == null) return NotFound();
            return Ok(actualizado);
        }

        [HttpDelete("servicios/{id}")]
        public async Task<ActionResult> DeleteServicio(int id)
        {
            var eliminado = await _catalogoService.DeleteServicioAsync(id);
            if (eliminado) return Ok();
            return BadRequest("No se pudo eliminar el servicio");
        }

        [HttpGet("estatusfallas")]
        public async Task<ActionResult<List<CatEstatusFalla>>> GetEstatusFallas()
        {
            var estatus = await _catalogoService.GetEstatusFallasAsync();
            return Ok(estatus);
        }

        [HttpPost("estatusfallas")]
        public async Task<ActionResult<CatEstatusFalla>> SetEstatusFalla([FromBody] CatEstatusFalla estatus)
        {
            var nuevoEstatus = await _catalogoService.SetEstatusFallaAsync(estatus);
            return Ok(nuevoEstatus);
        }

        [HttpPut("estatusfallas")]
        public async Task<ActionResult<CatEstatusFalla>> UpdateEstatusFalla([FromBody] CatEstatusFalla estatus)
        {
            var actualizado = await _catalogoService.UpdateEstatusFallaAsync(estatus);
            if (actualizado == null) return NotFound();
            return Ok(actualizado);
        }

        [HttpDelete("estatusfallas/{id}")]
        public async Task<ActionResult> DeleteEstatusFalla(int id)
        {
            var eliminado = await _catalogoService.DeleteEstatusFallaAsync(id);
            if (eliminado) return Ok();
            return BadRequest("No se pudo eliminar el estatus");
        }
    }
}
