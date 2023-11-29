using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Servicio
    {
        public string codigoservicio { get; set; }
        public string descripcion { get; set; }
        public int   precio { get; set; }
        

        public Servicio() { }

        public Servicio(string codigoservicio, string descripcion, int precio)
        {
            this.codigoservicio = codigoservicio;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public override string ToString()
        {
            return $"{codigoservicio};{descripcion};{precio};";
        }
       
    }
}
