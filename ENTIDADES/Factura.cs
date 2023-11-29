using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Factura
    {


        public string numerofactura { get; set; }
        public DateTime fecha { get; set; }
        public string cedulaCliente { get; set; }
        public string cedulaempleado { get; set; }
        public string placa { get; set; }
        public int preciototal { get; set; }
        




        public Factura() { }

        public Factura(string numerofactura, DateTime fecha, string cedulaCliente, string cedulaempleado, string placa, int preciototal)
        {
            this.numerofactura = numerofactura;
            this.fecha = fecha;
            this.cedulaCliente = cedulaCliente;
            this.cedulaempleado = cedulaempleado;
            this.placa = placa;
            this.preciototal = preciototal;
            
        }

        public override string ToString()
        {
            return $"{numerofactura};{fecha};{cedulaCliente};{cedulaempleado};{placa};{preciototal};";
        }
        //metodo para obtener el numero de factura que devuelva string




        

    }
}
