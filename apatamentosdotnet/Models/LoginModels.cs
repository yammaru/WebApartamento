using System;
using System.ComponentModel.DataAnnotations;
namespace mitadotnet.Models
{  
public class LoginInputModel
    {
        [Required]
        public string  IdUsuario { get; set; }

        [Required]
        public string Contraseña { get; set; }
    }

    public class LoginViewModel
    {
      public string IdUsuario{ get; set; }
        public string Nombre{ get; set; }
        public string Contraseña{ get; set; }
        public string Token { get; set; }

    }
    
}
