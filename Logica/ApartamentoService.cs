using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class ApartamentoService
    {
        private readonly ApartamentosContext _context;

        public ApartamentoService(ApartamentosContext context)
        {
            _context = context;
        }
        public GuardarApartamentoResponse Guardar(Apartamento apartamento)
        {

            try
            {
                var apartamentoEncontrado = _context.Apartamentoss.Find(apartamento.IdApartamento);
                if (apartamentoEncontrado != null)
                {
                    return new GuardarApartamentoResponse("Error, persona reguistrada");
                }

                _context.Apartamentoss.Add(apartamento);
                _context.SaveChanges();
                return new GuardarApartamentoResponse(apartamento);
            }
            catch (Exception e)
            {
                return new GuardarApartamentoResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
         public string Modificar(Apartamento apartamento)
        {
            try
            {
                _context.Apartamentoss.Update(apartamento);
                _context.SaveChanges();
                return ($"El Cliente {apartamento.IdApartamento} se ha modificado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public List<Apartamento> ConsultarTodos()
        {
            List<Apartamento> Apartamentos = _context.Apartamentoss.ToList();
            return Apartamentos;
        }
        public string Eliminar(string id)
        {
            try
            {
                var apartamento = _context.Apartamentoss.Find(id);
                if (apartamento != null)
                {
                    _context.Apartamentoss.Remove(apartamento);
                    _context.SaveChanges();

                    return ($"El registro {apartamento.IdApartamento} se ha eliminado satisfactoriamente.");
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
        public Apartamento BuscarxId(string id)
        {

            Apartamento apartamento = _context.Apartamentoss.Find(id);

            return apartamento;
        }

    }

    public class GuardarApartamentoResponse
    {
        public GuardarApartamentoResponse(Apartamento apartamento)
        {
            Error = false;
            Apartamento = apartamento;
        }
        public GuardarApartamentoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
