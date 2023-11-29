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
    public class GestionCuenta
    {

        public string InsertarCuenta(Cuenta cuenta)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FNS_CUENTAS.InsertarCuenta(:usuario, :contraseña); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = cuenta.usuario;
                comando.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = cuenta.contraseña;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                string resultado = comando.Parameters["result"].Value.ToString();

                if (resultado == "OK")
                {
                    Rpta = "OK";
                }
                else
                {
                    Rpta = "Error al guardar";
                }
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar Cuenta: " + ex.Message;
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

        public List<Cuenta> Listadousuraios()
        {
            OracleDataReader ResultadoUsuarios;
            List<Cuenta> usuarios = new List<Cuenta>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM VISTA_USUARIOS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoUsuarios = comando.ExecuteReader();

                while (ResultadoUsuarios.Read())
                {
                    Cuenta useruario = new Cuenta();
                    useruario.usuario = ResultadoUsuarios["usuario"].ToString();
                    useruario.contraseña = ResultadoUsuarios["contraseña"].ToString();
                    useruario.cedula = ResultadoUsuarios["cedula"].ToString();
                    useruario.Tipo_Cuenta = ResultadoUsuarios["tipo_de_cuenta"].ToString();
                    usuarios.Add(useruario);
                }

                return usuarios;
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

       

        public string EliminarCuenta(string usuario)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FNS_CUENTAS.EliminarCuenta(:p_usuario); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value = usuario;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "Error al Eliminar la cuenta: " + ex.Message;
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

    }
}
