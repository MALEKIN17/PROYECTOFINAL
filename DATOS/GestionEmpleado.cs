using ENTIDADES;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class GestionEmpleado
    {

        public string InsertarEmpleados(Empleado empleado)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_EMPLEADOS.InsertarEmpleado(:cedulaempleado, :primernombre, :primerapellido,:telefono,:cargo,:usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cedulacliente", OracleDbType.Varchar2).Value = empleado.cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = empleado.primernombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = empleado.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empleado.telefono;
                comando.Parameters.Add("cargo", OracleDbType.Varchar2).Value = empleado.cargo;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = empleado.usuario;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                Rpta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar empleado: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return Rpta;
        }
        public List<Empleado> DatosEmpleado()
        {
            OracleDataReader ResultadoEmpleado;
            List<Empleado> Empleados = new List<Empleado>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM empleados", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoEmpleado = comando.ExecuteReader();

                while (ResultadoEmpleado.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.cedula = ResultadoEmpleado["cedulaempleado"].ToString();
                    empleado.primernombre = ResultadoEmpleado["primernombre"].ToString();
                    empleado.primerapellido = ResultadoEmpleado["primerapellido"].ToString();
                    empleado.telefono = ResultadoEmpleado["telefono"].ToString();
                    empleado.usuario = ResultadoEmpleado["usuario"].ToString();
                    empleado.cargo = ResultadoEmpleado["cargo"].ToString();
                    
                    Empleados.Add(empleado);
                }

                return Empleados;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }


        public string Actualizarempleado(Empleado item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_EMPLEADOS.ActualizarEmpleado(:cedulaempleado, :primernombre, :primerapellido, :telefono); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = item.cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = item.primernombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = item.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = item.telefono;

                


                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al actualizar empleado: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return respuesta;
        }
        

        public string Eliminarempleado(string identificador)
        {
            string resultado = "";
            OracleConnection sqlconn = new OracleConnection();
            DataTable resultadoTabla = new DataTable();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := " +
                                       "FNS_EMPLEADOS.EliminarEmpleado(:p_emp_cedula);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_emp_cedula", OracleDbType.Varchar2).Value = identificador;
                


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar al empleado" + ex;
            }

            return resultado;
        }
    }
}
