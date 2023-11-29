using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cliente:Persona
    {
        

        public Cliente()
        {

        }

        public Cliente(string cedula, string primernombre, string primerapellido, string telefono) : base(cedula, primernombre, primerapellido, telefono)
        {
            
        }

        public override string ToString()
        {
            return $"{cedula};{primernombre};{primerapellido};{telefono};";
        }

     

       

        
    }
   

}
