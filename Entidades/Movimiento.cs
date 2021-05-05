using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidades
{
    public class Movimiento
    { 
        [Key]
        public string IdMovimiento{ get; set; }
        public int Valor{ get; set; }
        public string Detalle{ get; set; }
        public DateTime Fecha{ get; set; }
        [ForeignKey("Usuario")]
        public string IdUsuario{ get; set; }
    }
}
