using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Entidades
{
    public class Usuario
    { 
        [Key]
        public string IdUsuario{ get; set; }
        public string Nombre{ get; set; }
        public string Contraseña{ get; set; }
    
        
    }
}
