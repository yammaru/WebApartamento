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
    public class UsuarioController: ControllerBase
    {
        private readonly UsuarioService _usuarioService;
        public IConfiguration Configuration { get; }
        public UsuarioController(ApartamentosContext context)
        {
            _usuarioService = new  UsuarioService(context);
        }
         // PUT: api/Usuario/
        [HttpPut]
        public ActionResult<UsuarioViewModel> Put(UsuarioInputModel usuarioInput)
        {
            Usuario usuario = MapearPersona(usuarioInput);
            var mensaje = _usuarioService.Modificar(usuario);
            return Ok(mensaje);
        }
        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<UsuarioViewModel> Gets()
        {
            var movimientos = _usuarioService.ConsultarTodos().Select(p => new  UsuarioViewModel(p));
            return movimientos;
        }
        // GET: api/Usuario/5
        [HttpGet("{identificacion}")]
        public ActionResult<UsuarioViewModel> Get(string identificacion)
        {
            var usuario = _usuarioService.BuscarxId(identificacion);
            if (usuario == null) return NotFound();
            var usuarioViewModel = new  UsuarioViewModel(usuario);
            return usuarioViewModel;
        }
        // POST: api/Usuario
        [HttpPost]
        public ActionResult<UsuarioViewModel> Post(UsuarioInputModel usuarioInput)
        {
            Usuario movimiento = MapearPersona(usuarioInput);
            var response = _usuarioService.Guardar(movimiento);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Usuario);
        }
        // DELETE: api/Usuario/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _usuarioService.Eliminar(identificacion);
            return Ok(mensaje);
        }
        private  Usuario MapearPersona( UsuarioInputModel personaInput)
        {
            var persona = new  Usuario
            {
            IdUsuario=personaInput.IdUsuario,
            Nombre=personaInput.Nombre,
            Contraseña=personaInput.Contraseña,
      
            };
            return persona;
        }
    }
}
    