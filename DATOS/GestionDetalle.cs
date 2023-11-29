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
    public class GestionDetalle
    {

        public string Insertardetalle(Detalle item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {


                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FNS_DETALLES.InsertarDetalle( :nombreservicio, :precioservicio,:codfacturaservicio); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("descripcionservicio", OracleDbType.Varchar2).Value = item.descripcion;
                comando.Parameters.Add("precioservicio", OracleDbType.Varchar2).Value =   item.precio;
                comando.Parameters.Add("codfacturaservicio", OracleDbType.Varchar2).Value = item.numerofactura;
               
                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar detalle: " + ex.Message;
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



        public string Eliminardetalle(string identificador)
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
                                       "FNS_DETALLES.EliminarDetalle(:p_cod_factura);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_cod_factura", OracleDbType.Varchar2).Value = identificador;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el detalle" + ex;
            }

            return resultado;
        }

        public string Actualizardetalle(Detalle item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_DETALLES.actualizar_detalle(nombreservivcio, :descripcionservicio, :precioservicio,:codfacturaservicio); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("descripcionservicio", OracleDbType.Varchar2).Value = item.descripcion;
                comando.Parameters.Add("precioservicio", OracleDbType.Varchar2).Value = item.precio;
                comando.Parameters.Add("codfacturaservicio", OracleDbType.Varchar2).Value = item.numerofactura;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al actualizar el detalle: " + ex.Message;
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

        public List<Detalle> Consultardetalles()
        {

            OracleDataReader ResultadoClientes;
            List<Detalle> detalles = new List<Detalle>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM detalles", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Detalle detalle = new Detalle
                    {
                        codigodetalle = ResultadoClientes["codigodetalle"].ToString(),
                        numerofactura = ResultadoClientes["codfacturaservicio"].ToString(),
                        descripcion = ResultadoClientes["nombreservicio"].ToString(),
                        precio = Convert.ToInt32(ResultadoClientes["precioservicio"].ToString())

                    };
                    detalles.Add(detalle);

                    
                }

                return detalles;
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
