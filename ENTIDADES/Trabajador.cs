using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Trabajador
    {
        public string cedula { get; set; }
        public string primernombre { get; set; }
        public string primerapellido { get; set; }
        public string telefono { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string cargo { get; set; }

     public Trabajador()
        {

        }

        public Trabajador(string cedula, string primernombre, string primerapellido, string telefono, string usuario, string contraseña, string cargo)
        {
            this.cedula = cedula;
            this.primernombre = primernombre;
            this.primerapellido = primerapellido;
            this.telefono = telefono;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.cargo = cargo;
        }

        public override string ToString()
        {
            return $"{cedula};{primernombre};{primerapellido};{telefono};{usuario};{contraseña};{cargo};";
        }
    }
   
   

}
