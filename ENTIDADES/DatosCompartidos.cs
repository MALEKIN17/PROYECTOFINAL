using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DatosCompartidos
    {

        public static string Cedula { get; set; }
        public static string usuario { get; set; }
        public static string telefono { get; set; }
        public static string CedulaAdmin { get; set; }
        public static string CedulaNuevoEmp { get; set; }
        public static string CedulaEmp { get; set; }
        public static string usuariopropietario { get; set; }
        public static string usuarioEmpleado { get; set; }
        public static string nombreEmpleado { get; set; }
        public static string nombrePropietario { get; set; }
        public static string telefonoPropietario { get; set; }
        public static string telefonoEmpleado { get; set; }
        public static string Numerofactura { get; set; }

        public static string codigoservicio { get; set; }

       
        public static string ObtenerNumeroFactura()
        {
            return Numerofactura;
        }

        public static string ObtenerCedula()
                {
                    return Cedula;
                }

        public static void ActualizarCedula(string cedula)
        {
            Cedula = cedula;
        }


        

        public static void ActualizarUsuario(string usuario)
        {
            DatosCompartidos.usuario = usuario;
        }

        public static string ObtenerUsuario()
        {
            return usuario;
        }

        public static void ActualizarTelefono(string telefono)
        {
            DatosCompartidos.telefono = telefono;
        }

        public static string ObtenerTelefono()
        {
            return telefono;
        }


        public static void ActualizarUsuarioPropietario(string usuario)
        {
            usuariopropietario = usuario;
        }

        public static string ObtenerUsuarioPropietario()
        {
            return usuariopropietario;
        } 

        public static void ActualizarUsuarioEmpleado(string usuario)
        {
            usuarioEmpleado = usuario;
        }

        public static string ObtenerUsuarioEmpleado()
        {
            return usuarioEmpleado;
        }

        public static void ActualizarNombreEmpleado(string nombre)
        {
            nombreEmpleado = nombre;
        }

        public static string ObtenerNombreEmpleado()
        {
            return nombreEmpleado;
        }

        public static void ActualizarNombrePropietario(string nombre)
        {
            nombrePropietario = nombre;
        }

        public static string ObtenerNombrePropietario()
        {
            return nombrePropietario;
        }

        public static void ActualizarTelefonoPropietario(string telefono)
        {
            telefonoPropietario = telefono;
        }

        public static string ObtenerTelefonoPropietario()
        {
            return telefonoPropietario;
        }

        public static void ActualizarTelefonoEmpleado(string telefono)
        {
            telefonoEmpleado = telefono;
        }

        public static string ObtenerTelefonoEmpleado()
        {
            return telefonoEmpleado;
        }
        public static void ActualizarCedulaAdmin(string cedula)
        {
            CedulaAdmin = cedula;
        }


        public static string ObtenerCedulaAdmin()
        {
            return CedulaAdmin;
        }

        public static void ActualizarCedulaNuevoEmp(string cedula)
        {
            CedulaNuevoEmp = cedula;
        }


        public static string ObtenerCedulaNuevoEmp()
        {
            return CedulaNuevoEmp;
        }

        public static void ActualizarCedulaEmp(string cedula)
        {
            CedulaEmp = cedula;
        }


        public static string ObtenerCedulaEmp()
        {
            return CedulaEmp;
        }

    }
}
