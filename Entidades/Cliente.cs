using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Cliente
    { [Key]
        public string IdCliente{ get; set; }
        public string Nombre{ get; set; }
        public string Telefono{ get; set; }     
    }
}
