using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{

    public class Persona
    {
        public string cedula { get; set; }
        public string primernombre { get; set; }
        public string primerapellido { get; set; }
        public string telefono { get; set; }
        

        public Persona()
        {

        }

        public Persona(string cedula, string primernombre, string primerapellido, string telefono)
        {
            this.cedula = cedula;
            this.primernombre = primernombre;
            this.primerapellido = primerapellido;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"{cedula};{primernombre};{primerapellido};{telefono};";
        }

      
    }
    
}
