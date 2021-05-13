using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class MovimientoInputModel
    {  public string IdMovimiento{ get; set; }
        public int Valor{ get; set; }
        public string Detalle{ get; set; }
        public DateTime Fecha{ get; set; }
        public string IdUsuario{ get; set; }
    }

    public class MovimientoViewModel : MovimientoInputModel
    {
        public MovimientoViewModel()
        {

        }
        public MovimientoViewModel(Movimiento movimiento)
        {
            IdMovimiento=movimiento.IdMovimiento;
            Valor=movimiento.Valor;
            Detalle=movimiento.Detalle;
            Fecha=movimiento.Fecha;
            IdUsuario=movimiento.IdUsuario;
        }
        
    }

    public class MovimientoResponse
    {
        public IEnumerable<MovimientoViewModel> Movimientos {get;set;}
        public int Total => Movimientos.Sum(t=>t.Valor);
    } 
}