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
    public class ArriendoController : ControllerBase
    {
        private readonly ArriendoService _arriendoService;
        public IConfiguration Configuration { get; }
        public ArriendoController(ApartamentosContext context)
        {
            _arriendoService = new ArriendoService(context);
        }
        // GET: api/Arriendo
        [HttpGet]
        public IEnumerable<ArriendoViewModel> Gets()
        {
            var arriendos = _arriendoService.ConsultarTodos().Select(p => new ArriendoViewModel(p));
            return arriendos;
        }
        // GET: api/Arriendo/5
        [HttpGet("{identificacion}")]
        public ActionResult<ArriendoViewModel> Get(string identificacion)
        {
            var arriendo = _arriendoService.BuscarxId(identificacion);
            if (arriendo == null) return NotFound();
            var arriendoViewModel = new ArriendoViewModel(arriendo);
            return arriendoViewModel;
        }
        // POST: api/Arriendo
        [HttpPost]
        public ActionResult<ArriendoViewModel> Post(ArriendoInputModel arriendoInput)
        {
            Arriendo arriendo = Mapear(arriendoInput);
            var response = _arriendoService.Guardar(arriendo);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Arriendo);
        }
        // PUT: api/Arriendo/
        [HttpPut]
        public ActionResult<ArriendoViewModel> Put(ArriendoInputModel arriendoInput)
        {
            Arriendo arriendo = Mapear(arriendoInput);
            var mensaje = _arriendoService.Modificar(arriendo);
            return Ok(mensaje);
        }
        // DELETE: api/Arriendo/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _arriendoService.Eliminar(identificacion);
            return Ok(mensaje);
        }
        private Arriendo Mapear(ArriendoInputModel arriendoInput)
        {
            var arriendo = new Arriendo()
            {
                idArriendo = arriendoInput.idArriendo,
                fechaIngreso = arriendoInput.fechaIngreso,
                fechaDesalojo = arriendoInput.fechaDesalojo,
                Total=arriendoInput.Total,
                idCliente = arriendoInput.idCliente,
                idApartamento = arriendoInput.idApartamento,
               
             
            };


            return arriendo;
        }
    }
}
