using ENTIDADES;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DATOS
{
    public class GestionCliente 
    {

        public string Insertarcliente(Cliente cliente)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_CLIENTES.InsertarCliente(:cedulacliente, :primernombre, :primerapellido,:telefono); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cedulacliente", OracleDbType.Varchar2).Value = cliente.cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = cliente.primernombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = cliente.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.telefono;
                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar cliente: " + ex.Message;
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

        public string Eliminarcliente(string identificador)
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
                                       "FNS_CLIENTES.EliminarCliente(:p_cedula);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = identificador;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el cliente" + ex;
            }

            return resultado;
        }

            public string Actualizarcliente(Cliente item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_CLIENTES.ActualizarCliente(:cedulacliente, :primernombre, :primerapellido,:telefono); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cedulacliente", OracleDbType.Varchar2).Value = item.cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = item.primernombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = item.primerapellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = item.telefono;
                


                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar cliente: " + ex.Message;
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

        public List<Cliente> Consultarclientes()
        {

            OracleDataReader ResultadoClientes;
            List<Cliente> clientes = new List<Cliente>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM clientes", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.cedula = ResultadoClientes["cedulacliente"].ToString();
                    cliente.primernombre = ResultadoClientes["primernombre"].ToString();
                    cliente.primerapellido = ResultadoClientes["primerapellido"].ToString();
                    cliente.telefono = ResultadoClientes["telefono"].ToString();
                    

                    clientes.Add(cliente);
                }

                return clientes;
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
