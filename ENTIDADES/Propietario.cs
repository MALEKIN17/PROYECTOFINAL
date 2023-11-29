using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Propietario: Trabajador

    {
        public Propietario()
        {
        }

        public Propietario(string cedula, string primernombre, string primerapellido, string telefono, string usuario, string contraseña, string cargo) : base(cedula, primernombre, primerapellido, telefono, usuario, contraseña, cargo)
        {
        }

        public override string ToString()
        {
            return $"{cedula};{primernombre};{primerapellido};{telefono};{usuario};{contraseña};{cargo};";
        }
    }
}
