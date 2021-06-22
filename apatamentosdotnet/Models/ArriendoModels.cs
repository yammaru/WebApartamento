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
        public string IdApartamento { get; set; }
        public string IdMovimiento { get; set; }

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
            IdApartamento = arriendo.IdApartamento;
            IdMovimiento = arriendo.IdMovimiento;
           

        }
    }
}