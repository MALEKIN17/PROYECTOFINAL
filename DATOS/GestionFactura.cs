using ENTIDADES;
using Microsoft.Win32;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class GestionFactura 
    {
        public string Insertarfactura(Factura factura)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FNS_FACTURAS.InsertarFactura(:fecha,:cedulaCliente, :cedulaempleado, :placa, :preciototal); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("fecha", OracleDbType.Date).Value = factura.fecha;
                comando.Parameters.Add("cedulaCliente", OracleDbType.Varchar2).Value = factura.cedulaCliente;
                comando.Parameters.Add("cedulaempleado", OracleDbType.Varchar2).Value = factura.cedulaempleado;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = factura.placa;
                comando.Parameters.Add("preciototal", OracleDbType.Int32).Value = factura.preciototal;
                

                

                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al agregar la factura: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return resultado;
        }

        public string Eliminarfactura(string identificador)
        {
            string resultado = "";
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FNS_FACTURAS.EliminarFactura(:factura_id);END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("factura_id", OracleDbType.Int32).Value = int.Parse(identificador);
                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al Eliminar la factura: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return resultado;
        }

        public string Actualizarfactura(Factura item)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FNS_FACTURAS.ActualizarFactura(:numerofactura, :cedulaCliente, :cedulaempleado, :placa);END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("numerofactura", OracleDbType.Int32).Value = item.numerofactura;
                comando.Parameters.Add("cedulaCliente", OracleDbType.Varchar2).Value = item.cedulaCliente;
                comando.Parameters.Add("cedulaempleado", OracleDbType.Varchar2).Value = item.cedulaempleado;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = item.placa;
               


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al actualizar la factura: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return resultado;
        }

        public List<Factura> Listadofacturas()
        {
            OracleDataReader ResultadoUsuarios;
            List<Factura> facturas = new List<Factura>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM vistafacturas", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoUsuarios = comando.ExecuteReader();

                while (ResultadoUsuarios.Read())
                {
                    Factura factura = new Factura();

                    factura.cedulaCliente = ResultadoUsuarios["cedula"].ToString();
                    facturas.Add(factura);
                }

                return facturas;
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


        public List<Factura> Consultarfacturas()
        {
            List<Factura> Facturas = new List<Factura>();
            OracleDataReader ResultadoFacturas;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "SELECT * FROM Facturas";
                comando.CommandType = CommandType.Text;

                sqlconn.Open();
                ResultadoFacturas = comando.ExecuteReader();

                while (ResultadoFacturas.Read())
                {
                    Factura factura = new Factura();
                    factura.numerofactura = ResultadoFacturas["numerofactura"].ToString();
                    factura.fecha = DateTime.Parse(ResultadoFacturas["fecha"].ToString());
                    factura.cedulaCliente = ResultadoFacturas["cedulaCliente"].ToString();
                    factura.cedulaempleado = ResultadoFacturas["cedulaempleado"].ToString();
                    factura.placa = ResultadoFacturas["placa"].ToString();
                    factura.preciototal = Convert.ToInt32(ResultadoFacturas["preciototal"].ToString());
                    
                    


                    Facturas.Add(factura);
                }
                return Facturas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }

        //public List<Registro> ConsultarRegistro()
        //{
        //    List<Registro> Registros = new List<Registro>();
        //    OracleDataReader ResultadoRegistro;
        //    OracleConnection sqlconn = new OracleConnection();

        //    try
        //    {
        //        sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
        //        OracleCommand comando = new OracleCommand();
        //        comando.Connection = sqlconn;
        //        comando.CommandText = "SELECT * FROM REGISTROS";
        //        comando.CommandType = CommandType.Text;

        //        sqlconn.Open();
        //        ResultadoRegistro = comando.ExecuteReader();

        //        while (ResultadoRegistro.Read())
        //        {
        //            Registro Registro = new Registro();
        //            Registro.servicios = Convert.ToDouble(ResultadoRegistro["servicio"]);
        //            Registro.Prc_Revision = Convert.ToDouble(ResultadoRegistro["prc_revision"]);
        //            Registro.fecha_Fact = DateTime.Parse(ResultadoRegistro["fecha_fact"].ToString());
        //            Registro.Cliente_CC = ResultadoRegistro["cl_cedula"].ToString();
        //            Registro.Empleado_CC = ResultadoRegistro["emp_cedula"].ToString();
        //            Registro.placa = ResultadoRegistro["placa"].ToString();
        //            Registro.Cod_Factura = ResultadoRegistro["cod_factura"].ToString();
        //            Registro.Accion = ResultadoRegistro["accion"].ToString();


        //            Registros.Add(Registro);
        //        }
        //        return Registros;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (sqlconn.State == ConnectionState.Open)
        //        {
        //            sqlconn.Close();
        //        }
        //    }
        //}

    }
}
