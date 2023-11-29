using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cuenta
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public string cedula { get; set; }
        public string Tipo_Cuenta { get; set; }

        public Cuenta(string usuario, string contraseña, string cedula, string tipo_Cuenta)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.cedula = cedula;
            Tipo_Cuenta = tipo_Cuenta;
        }

        public Cuenta()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
