using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornMVC2.Data.Entities
{
    public class Producto : IdentityBase
    {
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }

        public DateTime UltimaActualizacion { get; set; }

        public int CategoryId { get; set; }

    }
}