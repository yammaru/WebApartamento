using System;
using System.ComponentModel.DataAnnotations;
namespace mitadotnet.Models
{  
public class LoginInputModel
    {
        [Required]
        public string  IdUsuario { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class LoginViewModel
    {
      public string IdUsuario{ get; set; }
        public string Nombre{ get; set; }
        public string Password{ get; set; }
        public string Token { get; set; }

    }
    
}
