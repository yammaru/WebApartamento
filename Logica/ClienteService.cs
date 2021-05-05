using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class ClienteService
    {
        private readonly ApartamentosContext _context;

        public ClienteService(ApartamentosContext context)
        {
            _context = context;
        }
        public GuardarClienteResponse Guardar(Cliente cliente)
        {

            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return new GuardarClienteResponse(cliente);
            }
            catch (Exception e)
            {
                return new GuardarClienteResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
        public string Modificar(Cliente cliente)
        {
            try
            {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                return ($"El Cliente {cliente.IdCliente} se ha modificado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> Clientes = _context.Clientes.ToList();
            return Clientes;
        }
        public string Eliminar(string id)
        {
            try
            {
                var persona = _context.Clientes.Find(id);
                if (persona != null)
                {
                    _context.Clientes.Remove(persona);
                    _context.SaveChanges();

                    return ($"El registro {persona.IdCliente} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {id} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }


        }
        public Cliente BuscarxId(string identificacion)
        {

            Cliente persona = _context.Clientes.Find(identificacion);

            return persona;
        }

    }

    public class GuardarClienteResponse
    {
        public GuardarClienteResponse(Cliente persona)
        {
            Error = false;
            Persona = persona;
        }
        public GuardarClienteResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Persona { get; set; }
    }
}
