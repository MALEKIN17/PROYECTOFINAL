using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public class ServicioCuenta
    {
       
        GestionCuenta G_cuentas = new GestionCuenta();
        GestionInicio G_inicio = new GestionInicio();



        public string InsertarCuenta(Cuenta cuenta)
        {
            string msg2 = G_cuentas.InsertarCuenta(cuenta);
            return msg2;
        }


        public Cuenta DatosCuenta(string Cedula)
        {
            Cuenta Usuario = new Cuenta();
            List<Cuenta> Users = G_cuentas.Listadousuraios();

            foreach (Cuenta Cuenta in Users)
            {
                if (Cuenta.cedula == Cedula)
                {
                    Usuario.usuario = Cuenta.usuario;
                    Usuario.contraseña = Cuenta.contraseña;
                    Usuario.cedula = Cuenta.cedula;
                    Usuario.Tipo_Cuenta = Cuenta.Tipo_Cuenta;
                }
            }
            return Usuario;
        }

        public DataTable V_Cuentas()
        {
            DataTable V_cuentas = new DataTable();
            V_cuentas = G_inicio.ListadoCuentas();
            return V_cuentas;

        }

        public DataTable V_PERSONAS()
        {
            DataTable V_PERSONAS = new DataTable();
            V_PERSONAS = G_inicio.ListadoPersonas();
            return V_PERSONAS;

        }

        public Persona ObtenerNombre(string cedula)
        {
            List<Persona> personas = new List<Persona>();
            personas = G_inicio.ObtenerNombres();
            Persona persona = new Persona();
            foreach (Persona person in personas)
            {
                if (person.cedula == cedula)
                {
                    persona = person;
                }


            }
            return persona;

        }

       

        public Trabajador ObtenerDatos(string cedula)
        {
            List<Trabajador> trabajadores = new List<Trabajador>();
            trabajadores = G_inicio.ObtenerDatostrabajadores();
            Trabajador trabajador = new Trabajador();
            foreach (Trabajador trabajad in trabajadores)
            {
                
                if (trabajad.cedula == cedula)
                {
                    trabajador = trabajad;
                }
            }
            return trabajador;

        }


        public string EliminarCuenta(string usuario)
        {
            string msg = G_cuentas.EliminarCuenta(usuario);
            return msg;
        }
    }
}
