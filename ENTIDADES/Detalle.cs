using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Detalle : Servicio

    {
        public string codigodetalle { get; set; }
        public string numerofactura { get; set; }

        public Detalle()
        {

        }

        public Detalle(string codigodetalle, string numerofactura, string descripcion, int precio) : base(codigodetalle, descripcion, precio)
        {
            this.codigodetalle = codigodetalle;
            this.numerofactura = numerofactura;
        }

        public override string ToString()
        {
            return $"{codigodetalle};{numerofactura};{descripcion};{precio};";
        }

       

        

    }
}
