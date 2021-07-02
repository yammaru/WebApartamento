using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class ArriendoInputModel
    {
        public string idArriendo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaDesalojo { get; set; }
        public int Total{get;set;}
        public string idCliente { get; set; }
        public string idApartamento { get; set; }
   

    }

    public class ArriendoViewModel : ArriendoInputModel
    {
        public ArriendoViewModel()
        {

        }
        public ArriendoViewModel(Arriendo arriendo)
        {
            idArriendo = arriendo.idArriendo;
            fechaIngreso = arriendo.fechaIngreso;
            fechaDesalojo = arriendo.fechaDesalojo;
            Total=arriendo.Total;
            idCliente = arriendo.idCliente;
            idApartamento = arriendo.idApartamento;
   

        }
    }
}