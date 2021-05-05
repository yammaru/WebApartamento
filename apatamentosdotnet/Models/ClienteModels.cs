using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class ClienteInputModel
    {
        public string IdCliente{ get; set; }
        public string Nombre{ get; set; }
        public string Telefono{ get; set; }     

    }

    public class ClienteViewModel : ClienteInputModel
    {
        public  ClienteViewModel()
        {

        }
        public  ClienteViewModel(Cliente persona)
        {
            IdCliente=persona.IdCliente;
            Nombre = persona.Nombre;
            Telefono=persona.Telefono;
        }
        
    }
}