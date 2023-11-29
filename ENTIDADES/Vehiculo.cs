using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Vehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string cedulaCliente { get; set; }

        public Vehiculo() { }

        public Vehiculo(string marca, string modelo, string placa, string cedulaCliente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cedulaCliente = cedulaCliente;
        }

        public override string ToString()
        {
            return $"{marca};{modelo};{placa};{cedulaCliente};";
        }   

    }
}
