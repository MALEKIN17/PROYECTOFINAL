using ENTIDADES;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class GestionPropietario
    {

        public string Insertarpropietario(Propietario propietario)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_PROPIETARIOS.InsertarPropietario(:cedulapropietario, :primernombre, :primerapellido,:telefono,:cargo,:usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cedulapropietario", OracleDbType.Varchar2).Value = propietario.cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = propietario.primernombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = propietario.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = propietario.telefono;
                comando.Parameters.Add("cargo", OracleDbType.Varchar2).Value = propietario.cargo;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = propietario.usuario;
               
                

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar al propietario: " + ex.Message;
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

        public string Eliminarpropietario(string identificador)
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
                                       "FNS_PROPIETARIOS.EliminarPropietario(:p_propietario_cedula);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_propietario_cedula", OracleDbType.Varchar2).Value = identificador;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el propietario" + ex;
            }

            return resultado;
        }

        public string Actualizarpropietario(Propietario item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_PROPIETARIOS.ActualizarPropietario(:cedulapropietario, :primernombre, :primerapellido,:telefono,:cargo,:usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cedulapropietario", OracleDbType.Varchar2).Value = item.cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = item.primernombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = item.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = item.telefono;
                comando.Parameters.Add("cargo", OracleDbType.Varchar2).Value = item.cargo;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = item.usuario;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al actualizar el propietario: " + ex.Message;
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

       

        public List<Propietario> Consultarpropietarios()
        {

            OracleDataReader ResultadoClientes;
            List<Propietario> propietarios = new List<Propietario>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM propietarios", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Propietario propietario = new Propietario();
                    propietario.cedula = ResultadoClientes["cedulapropietario"].ToString();
                    propietario.primernombre = ResultadoClientes["primernombre"].ToString();
                    propietario.primerapellido = ResultadoClientes["primerapellido"].ToString();
                    propietario.telefono = ResultadoClientes["telefono"].ToString();
                    propietario.cargo = ResultadoClientes["cargo"].ToString();
                    propietario.usuario = ResultadoClientes["usuario"].ToString();
                    propietario.contraseña = ResultadoClientes["contraseña"].ToString();

                    propietarios.Add(propietario);
                }

                return propietarios;
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
    }
}
