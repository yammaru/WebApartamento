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
                var arriendoEncontrado = _context.Arriendos.Find(arriendo.idArriendo);
                if (arriendoEncontrado != null)
                {
                    return new GuardarArriendoResponse("Error, Arriendo registrado");
                }
                _context.Arriendos.Add(arriendo);
                _context.SaveChanges();
                
                return new GuardarArriendoResponse(arriendo);
            }
            catch (Exception e)
            {
                return new GuardarArriendoResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
    public string Modificar(Arriendo arriendo)
        {
            try
            {
                _context.Arriendos.Update(arriendo);
                _context.SaveChanges();
                return ($"El Cliente {arriendo.idArriendo} se ha modificado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
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

                    return ($"El registro {arriendo.idArriendo} se ha eliminado satisfactoriamente.");
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
