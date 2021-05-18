using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class MovimientoService
    {
        private readonly ApartamentosContext _context;

        public MovimientoService(ApartamentosContext context)
        {
            _context = context;
        }
        public string Modificar(Movimiento movimiento)
        {
            try
            {
                _context.Movimientos.Update(movimiento);
                _context.SaveChanges();
                return ($"El Cliente {movimiento.IdMovimiento} se ha modificado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public GuardarMovimientoResponse Guardar(Movimiento movimiento)
        {

            try
            {
                var MovimientoEncontrado = _context.Movimientos.Find(movimiento.IdMovimiento);
                if (MovimientoEncontrado != null)
                {
                    return new GuardarMovimientoResponse("Error, Movimiento reguistrado");
                }

                _context.Movimientos.Add(movimiento);
                _context.SaveChanges();
                return new GuardarMovimientoResponse(movimiento);
            }
            catch (Exception e)
            {
                return new GuardarMovimientoResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
        public List<Movimiento> ConsultarTodos()
        {
            List<Movimiento> Movimientos = _context.Movimientos.ToList();
            return Movimientos;
        }

        public string Eliminar(string id)
        {
            try
            {
                var movimiento = _context.Movimientos.Find(id);
                if (movimiento != null)
                {
                    _context.Movimientos.Remove(movimiento);
                    _context.SaveChanges();

                    return ($"El registro {movimiento.IdMovimiento} se ha eliminado satisfactoriamente.");
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
        public Movimiento BuscarxId(string id)
        {

            Movimiento movimiento = _context.Movimientos.Find(id);

            return movimiento;
        }

        public int Totalizar()
        {
            return _context.Movimientos.Sum(p => p.Valor);
        }
        /* public int TotalizarHombres()
         {
             return _context.Movimientos.Count(p=>p.Sexo=="M");
         }*/

    }

    public class GuardarMovimientoResponse
    {
        public GuardarMovimientoResponse(Movimiento movimiento)
        {
            Error = false;
            Movimiento = movimiento;
        }
        public GuardarMovimientoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Movimiento Movimiento { get; set; }
    }
}
