using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Datos;
using mitadotnet.Models;

namespace mitadotnet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;
        public IConfiguration Configuration { get; }
        public ClienteController(ApartamentosContext context)
        {
            _clienteService = new ClienteService(context);
        }
        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<ClienteViewModel> Gets()
        {
            var personas = _clienteService.ConsultarTodos().Select(p => new ClienteViewModel(p));
            return personas;
        }
        // GET: api/Cliente/5
        [HttpGet("{identificacion}")]
        public ActionResult<ClienteViewModel> Get(string identificacion)
        {
            var persona = _clienteService.BuscarxId(identificacion);
            if (persona == null) return NotFound();
            var personaViewModel = new ClienteViewModel(persona);
            return personaViewModel;
        }
        // POST: api/Cliente
        [HttpPost]
        public ActionResult<ClienteViewModel> Post(ClienteInputModel personaInput)
        {
            Cliente persona = MapearPersona(personaInput);
            var response = _clienteService.Guardar(persona);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }
        // DELETE: api/Cliente/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _clienteService.Eliminar(identificacion);
            return Ok(mensaje);
        }
        private Cliente MapearPersona(ClienteInputModel personaInput)
        {
            var persona = new Cliente
            {
                IdCliente = personaInput.IdCliente,
                Nombre = personaInput.Nombre,
                Telefono = personaInput.Telefono,
            };
            return persona;
        }
    }
}
    