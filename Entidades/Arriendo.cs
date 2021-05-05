using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Arriendo
    { 
        [Key]
        public string IdArriendo{ get; set; }
        public DateTime fechaIngreso{ get; set; }
        public DateTime fechaDesalojo{ get; set; }
        public int Total{get;set;}
        [ForeignKey("Cliente")]
        public string IdCliente{ get; set; }
        public Cliente Cliente{get;set;}
        [ForeignKey("Apartamento")]
        public string IdApartamento{ get; set; }
    
        public Movimiento Movimiento{get;set; }
    }
}
