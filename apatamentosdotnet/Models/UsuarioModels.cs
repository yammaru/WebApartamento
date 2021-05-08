using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mitadotnet.Models
{
    public class UsuarioInputModel
    {   public string IdUsuario{ get; set; }
        public string Nombre{ get; set; }
        public string Password{ get; set; }

    }

    public class UsuarioViewModel : UsuarioInputModel
    {
        public UsuarioViewModel()
        {

        }
        public UsuarioViewModel(Usuario persona)
        {
            IdUsuario=persona.IdUsuario;
            Nombre=persona.Nombre;
            Password=persona.Password;

        }
        
    }
}