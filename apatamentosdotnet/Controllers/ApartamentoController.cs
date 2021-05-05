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
    public class PersonaController : ControllerBase
    {
        private readonly ApartamentoService _apartamentoService;
        public IConfiguration Configuration { get; }
        public PersonaController(ApartamentosContext context)
        {
            _apartamentoService = new ApartamentoService(context);
        }
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<ApartamentoViewModel> Gets()
        {
            var personas = _apartamentoService.ConsultarTodos().Select(p => new ApartamentoViewModel(p));
            return personas;
        }
        // GET: api/Persona/5
        [HttpGet("{identificacion}")]
        public ActionResult<ApartamentoViewModel> Get(string identificacion)
        {
            var persona = _apartamentoService.BuscarxId(identificacion);
            if (persona == null) return NotFound();
            var personaViewModel = new ApartamentoViewModel(persona);
            return personaViewModel;
        }
        // POST: api/Persona
        [HttpPost]
        public ActionResult<ApartamentoViewModel> Post(ApartamentoInputModel apartamentoInput)
        {
            Apartamento apartamento = Mapear(apartamentoInput);
            var response = _apartamentoService.Guardar(apartamento);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Apartamento);
        }
        // DELETE: api/Persona/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _apartamentoService.Eliminar(identificacion);
            return Ok(mensaje);
        }
        private Apartamento Mapear(ApartamentoInputModel apartamentoInput)
        {
            var apartamento = new Apartamento
            {
                IdApartamento = apartamentoInput.IdApartamento,
                ValorApartamento= apartamentoInput.ValorApartamento,
                Estado = apartamentoInput.Estado,
                Deposito = apartamentoInput.Deposito
            };
            return apartamento;
        }
    }
}