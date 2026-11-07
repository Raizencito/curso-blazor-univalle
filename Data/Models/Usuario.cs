using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpness_sharp.Data.Models
{
     public class Usuario
    {
        public string? NombreUsuario { get; set; }
        public string? CorreoUsuario { get; set; }
        public string? ImagenUsuario { get; set; }
        public decimal tamano { get; set; }

        public int edadUsuario { get; set; }

        public Usuario(string nombre, string correo, string imagen)
        {
            NombreUsuario = nombre;
            CorreoUsuario = correo;
            ImagenUsuario = imagen;
            tamano = 0;
            edadUsuario = 0;
        }
    }
}