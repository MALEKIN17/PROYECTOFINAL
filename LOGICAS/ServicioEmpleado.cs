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
    public partial class ServicioEmpleado
    {
        GestionEmpleado G_Empleados = new GestionEmpleado();



        public string InsertarEmpleado(Empleado empleado)
        {
            string msg1 = G_Empleados.InsertarEmpleados(empleado);
            return msg1;
        }



       
        
        public Empleado ObtenerDatosEmpleado(string Cedula)
        {

            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = new Empleado();

            empleados = G_Empleados.DatosEmpleado();
            foreach (Empleado Emp in empleados)
            {
                if (Emp.cedula == Cedula)
                {
                    empleado.cedula = Emp.cedula;
                    empleado.primernombre = Emp.primernombre;
                    empleado.primerapellido = Emp.primerapellido;
                    empleado.telefono = Emp.telefono;
                    empleado.cargo = Emp.cargo;

                }
            }

            return empleado;
        }
        

        public string ActualizarEmpleado(Empleado empleado)
        {
            string msg = G_Empleados.Actualizarempleado(empleado);
            return msg;
        }

        public List<Empleado> ObtenerTodosEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados = G_Empleados.DatosEmpleado();
            return empleados;
        }

        public string EliminarEmpleado(string CedulEmp )
        {
            string msg = G_Empleados.Eliminarempleado(CedulEmp);
            return msg;
        }
    }
}
