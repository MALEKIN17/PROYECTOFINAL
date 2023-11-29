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
    public class GestionVehiculo
    {
        public string Insertarvehiculo(Vehiculo item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_VEHICULOS.InsertarVehiculo(:marca, :modelo, :placa, :cedulacliente); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("marca", OracleDbType.Varchar2).Value = item.marca;
                comando.Parameters.Add("modelo", OracleDbType.Varchar2).Value = item.modelo;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = item.placa;
                comando.Parameters.Add("cedulacliente", OracleDbType.Varchar2).Value = item.cedulaCliente;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar el vehiculo: " + ex.Message;
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

        public string Eliminarvehiculo(string identificador)
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
                                       "FNS_VEHICULOS.EliminarVehiculos(:p_cliente_id);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_cliente_id", OracleDbType.Varchar2).Value = identificador;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el vehiculo" + ex;
            }

            return resultado;
        }

        public string Actualizarvehiculo(Vehiculo item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_VEHICULOS.ActualizarVehiculo(:marca, :modelo, :placa, :cedulacliente); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("marca", OracleDbType.Varchar2).Value = item.marca;
                comando.Parameters.Add("modelo", OracleDbType.Varchar2).Value = item.modelo;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = item.placa;
                comando.Parameters.Add("cedulacliente", OracleDbType.Varchar2).Value = item.cedulaCliente;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al actualizar el vehiculo: " + ex.Message;
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

        public List<Vehiculo> Consultarvehiculos()
        {

            OracleDataReader ResultadoClientes;
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM vehiculos", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Vehiculo vehiculo = new Vehiculo();

                    vehiculo.marca = ResultadoClientes["marca"].ToString();
                    vehiculo.modelo = ResultadoClientes["modelo"].ToString();
                    vehiculo.placa = ResultadoClientes["placa"].ToString();
                    vehiculo.cedulaCliente = ResultadoClientes["cedulacliente"].ToString();

                    vehiculos.Add(vehiculo);
                }

                return vehiculos;
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
