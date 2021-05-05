using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class ArriendoInputModel
    {
        public string IdArriendo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaDesalojo { get; set; }
        public int Total{get;set;}
        public string IdCliente { get; set; }
        public ClienteInputModel Cliente { get; set; } = new ClienteInputModel();
        public string IdApartamento { get; set; }
        public string IdMovimiento { get; set; }
        public MovimientoInputModel Movimiento { get; set; } = new MovimientoInputModel();

    }

    public class ArriendoViewModel : ArriendoInputModel
    {
        public ArriendoViewModel()
        {

        }
        public ArriendoViewModel(Arriendo arriendo)
        {
            IdArriendo = arriendo.IdArriendo;
            fechaIngreso = arriendo.fechaIngreso;
            fechaDesalojo = arriendo.fechaDesalojo;
            Total=arriendo.Total;
            IdCliente = arriendo.IdCliente;
            Cliente.IdCliente = arriendo.Cliente.IdCliente;
            Cliente.Nombre = arriendo.Cliente.Nombre;
            Cliente.Telefono = arriendo.Cliente.Telefono;
            IdApartamento = arriendo.IdApartamento;
            Movimiento.IdMovimiento = arriendo.Movimiento.IdMovimiento;
            Movimiento.Valor = arriendo.Movimiento.Valor;
            Movimiento.Detalle = arriendo.Movimiento.Detalle;
            Movimiento.Fecha = arriendo.Movimiento.Fecha;
            Movimiento.IdUsuario = arriendo.Movimiento.IdUsuario;

        }
    }
}