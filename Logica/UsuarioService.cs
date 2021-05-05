using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class UsuarioService
    {
        private readonly ApartamentosContext _context;

        public UsuarioService(ApartamentosContext context)
        {
            _context = context;
        }
          public string Modificar(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
                return ($"El Cliente {usuario.IdUsuario} se ha modificado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public GuardarUsuarioResponse Guardar(Usuario persona)
        {

            try
            {
                var personaEncontrada = _context.Usuarios.Find(persona.IdUsuario);
                if (personaEncontrada != null)
                {
                    return new GuardarUsuarioResponse("Error, Usuario reguistrado");
                }

                _context.Usuarios.Add(persona);
                _context.SaveChanges();
                return new GuardarUsuarioResponse(persona);
            }
            catch (Exception e)
            {
                return new GuardarUsuarioResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> Usuarios = _context.Usuarios.ToList();
            return Usuarios;
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                var persona = _context.Usuarios.Find(identificacion);
                if (persona != null)
                {
                    _context.Usuarios.Remove(persona);
                    _context.SaveChanges();

                    return ($"El registro {persona.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }


        }
        public Usuario BuscarxId(string identificacion)
        {

           Usuario persona = _context.Usuarios.Find(identificacion);

            return persona;
        }

    }
 
    public class GuardarUsuarioResponse
    {
        public GuardarUsuarioResponse(Usuario persona)
        {
            Error = false;
            Usuario = persona;
        }
        public GuardarUsuarioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Usuario Usuario{ get; set; }
    }
}
