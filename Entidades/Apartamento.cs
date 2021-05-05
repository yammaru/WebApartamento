using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Apartamento
    { [Key]
        public string IdApartamento{ get; set; }
        public int ValorApartamento{ get; set; }
        public int Deposito{ get; set; }
        public string Estado{ get; set; }
        }
}
