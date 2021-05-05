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
    public class MovimientoController: ControllerBase
    {
        private readonly  MovimientoService _movimientoService;
        public IConfiguration Configuration { get; }
        public MovimientoController(ApartamentosContext context)
        {
            _movimientoService = new  MovimientoService(context);
        }
        // PUT: api/movimiento/
        [HttpPut]
        public ActionResult<MovimientoViewModel> Put(MovimientoInputModel movimientoInput)
        {
            Movimiento movimiento = Mapear(movimientoInput);
            var mensaje = _movimientoService.Modificar(movimiento);
            return Ok(mensaje);
        }
        // GET: api/Movimiento
        [HttpGet]
        public IEnumerable< MovimientoViewModel> Gets()
        {
            var movimientos = _movimientoService.ConsultarTodos().Select(p => new  MovimientoViewModel(p));
            return movimientos;
        }
        // GET: api/Movimiento/5
        [HttpGet("{identificacion}")]
        public ActionResult< MovimientoViewModel> Get(string identificacion)
        {
            var movimiento = _movimientoService.BuscarxId(identificacion);
            if (movimiento == null) return NotFound();
            var movimientoViewModel = new  MovimientoViewModel(movimiento);
            return movimientoViewModel;
        }
        // POST: api/Movimiento
        [HttpPost]
        public ActionResult< MovimientoViewModel> Post( MovimientoInputModel movimientoInput)
        {
            Movimiento movimiento = Mapear(movimientoInput);
            var response = _movimientoService.Guardar(movimiento);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Movimiento);
        }
        // DELETE: api/Movimiento/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _movimientoService.Eliminar(identificacion);
            return Ok(mensaje);
        }
        private  Movimiento Mapear( MovimientoInputModel movimientoInput)
        {
            var movimiento = new  Movimiento
            {
                IdMovimiento=movimientoInput.IdMovimiento,
                Valor=movimientoInput.Valor,
                Detalle=movimientoInput.Detalle,
                Fecha=movimientoInput.Fecha,
                IdUsuario=movimientoInput.IdUsuario
            };
            return movimiento;
        }
    }
}
    