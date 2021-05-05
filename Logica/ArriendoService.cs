using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class ArriendoService
    {
        private readonly ApartamentosContext _context;

        public ArriendoService(ApartamentosContext context)
        {
            _context = context;
        }
        public GuardarArriendoResponse Guardar(Arriendo arriendo)
        {

            try
            {
                var arriendoEncontrado = _context.Arriendos.Find(arriendo.IdArriendo);
                if (arriendoEncontrado != null)
                {
                    return new GuardarArriendoResponse("Error, Usuario reguistrado");
                }

                _context.Arriendos.Add(arriendo);
                _context.SaveChanges();
                codigo();
                return new GuardarArriendoResponse(arriendo);
            }
            catch (Exception e)
            {
                return new GuardarArriendoResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
int i;
        private string codigo()
        {
            return $"[100{i+1}]";
        }

        public List<Arriendo> ConsultarTodos()
        {
            List<Arriendo> Arriendos = _context.Arriendos.ToList();
            return Arriendos;
        }
        public string Eliminar(string id)
        {
            try
            {
                var arriendo = _context.Arriendos.Find(id);
                if (arriendo != null)
                {
                    _context.Arriendos.Remove(arriendo);
                    _context.SaveChanges();

                    return ($"El registro {arriendo.IdArriendo} se ha eliminado satisfactoriamente.");
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
        public Arriendo BuscarxId(string identificacion)
        {

            Arriendo persona = _context.Arriendos.Find(identificacion);

            return persona;
        }
        public int Totalizar()
        {
            return _context.Arriendos.Count();
        }

    }

    public class GuardarArriendoResponse
    {
        public GuardarArriendoResponse(Arriendo arriendo)
        {
            Error = false;
            Arriendo = arriendo;
        }
        public GuardarArriendoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Arriendo Arriendo { get; set; }
    }
}
