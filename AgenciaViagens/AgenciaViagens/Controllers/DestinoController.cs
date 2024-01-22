using AgenciaViagens.Models;
using AgenciaViagens.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViagens.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DestinoController : ControllerBase
    {
        private readonly IDestinoRepositorio _destinoRepositorio;

        public DestinoController(IDestinoRepositorio destinoRepositorio)
        {
            _destinoRepositorio = destinoRepositorio;
        }   

        [HttpGet]
        public async Task<ActionResult<List<DestinoModel>>> BuscarTodosDestinos()
        {
            List<DestinoModel> destinos =  await _destinoRepositorio.BuscarTodosUsuarios();
            return Ok(destinos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DestinoModel>> BuscarPorId(int id)
        {
            DestinoModel destino = await _destinoRepositorio.BuscarPorId(id);
            return Ok(destino);
        }

    }
}
