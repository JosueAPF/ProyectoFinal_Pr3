using Microsoft.AspNetCore.Mvc;
using TarjetasCredito_API_Rest.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TarjetasCredito_API_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargaInicialController : ControllerBase
    {
        public readonly CargaInicialServicio cargaInicial;
        public CargaInicialController(CargaInicialServicio carga)
        {
            cargaInicial = carga;
        }

        [HttpGet("Clientes")]
        public IActionResult showClientes()
        {
            return Ok(cargaInicial.verClientes());
        }

        [HttpGet("Tarjetas")]
        public IActionResult RutaArchivo() { 
            return Ok(cargaInicial.verTarjetas());
        }   

       
    }
}
