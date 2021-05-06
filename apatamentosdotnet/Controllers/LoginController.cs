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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using mitadotnet.Service;

namespace mitadotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        private readonly JwtService _jwtService;

        private readonly UsuarioService _usuarioService;
        public IConfiguration Configuration { get; }
        public LoginController(ApartamentosContext context, IOptions<AppSetting> appSetting)
        {
            _usuarioService = new UsuarioService(context);
            _jwtService = new JwtService(appSetting);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginInputModel model)
        {
            var user = _usuarioService.Validate(model.IdUsuario, model.Contraseña);
            if (user == null) return BadRequest("Username or password is incorrect");
            var response = _jwtService.GenerateToken(user);
            return Ok(response);
        }
    }
}
