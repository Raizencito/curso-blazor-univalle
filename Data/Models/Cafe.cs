using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpness_sharp.Data.Models
{
    public class Cafe
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string NombreCafe { get; set; }
        public string DescripcionCafe { get; set; }
        public decimal PrecioCafe { get; set; }

        public Cafe(string imagen, string nombreCafe, string descripcionCafe, decimal precioCafe)
        {
            Imagen = imagen;
            NombreCafe = nombreCafe;
            DescripcionCafe = descripcionCafe;
            PrecioCafe = precioCafe;
        }
        //Constructor por def
        public Cafe()
        {
            Imagen = "https://cuplacoffee.com/wp-content/uploads/2025/03/what-is-an-americano-featured.jpg";
            NombreCafe = "Nuevo Café";
            DescripcionCafe = "Descripción del nuevo café.";
            PrecioCafe = 20m;
        }
    }
}