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
    public class GestionServicio
    {

        public string Insertarservicio(Servicio item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_SERVICIOS.InsertarServicio(:nombreservicio, :precioservicio); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("descripcionservicio", OracleDbType.Varchar2).Value = item.descripcion;
                comando.Parameters.Add("precioservicio", OracleDbType.Decimal).Value = item.precio;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar el servicio: " + ex.Message;
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

        public string Eliminarservicio(string identificador)
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
                                       "FNS_SERVICIOS.EliminarServicio(:p_cod_servicio);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_cod_servicio", OracleDbType.Int32).Value = identificador;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el servicio" + ex;
            }

            return resultado;
        }

        public string Actualizarservicio(Servicio item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_SERVICIOS.ActualizarServicio(:codigoservicio,:nombreservicio, :precioservicio); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("codigoservicio", OracleDbType.Int32).Value = Convert.ToInt32(item.codigoservicio) ;
                comando.Parameters.Add("nombreservicio", OracleDbType.Varchar2).Value = item.descripcion;
                comando.Parameters.Add("precioservicio", OracleDbType.Int32).Value = item.precio;


                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al actualizar el servicio: " + ex.Message;
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

        public List<Servicio> Consultarservicios()
        {

            OracleDataReader ResultadoClientes;
            List<Servicio> servicios = new List<Servicio>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM servicios", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Servicio servicio = new Servicio();
                    servicio.descripcion = ResultadoClientes["nombreservicio"].ToString();
                    servicio.precio = Convert.ToInt32(ResultadoClientes["precioservicio"].ToString());
                    servicio.codigoservicio = ResultadoClientes["codigoservicio"].ToString();
                    servicios.Add(servicio);
                }

                return servicios;
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
