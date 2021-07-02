using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Arriendo
    { 
        [Key]
        public string idArriendo{ get; set; }
        public DateTime fechaIngreso{ get; set; }
        public DateTime fechaDesalojo{ get; set; }
        public int Total{get;set;}
        [ForeignKey("Cliente")]
        public string idCliente{ get; set; }
        [ForeignKey("Apartamento")]
        public string idApartamento{ get; set; }
    }
}
