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
    public class GestionInicio
    {
        public DataTable ListadoCuentas()
        {
            OracleDataReader ResultadoCuentas;
            DataTable TablaCuentas = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM VISTA_USUARIOS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoCuentas = comando.ExecuteReader();
                TablaCuentas.Load(ResultadoCuentas);
                return TablaCuentas;
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

        public DataTable ListadoPersonas()
        {
            OracleDataReader Resultadopersonas;
            DataTable Tablapersonas = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM V_NOMBRES_CEDULAS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                Resultadopersonas = comando.ExecuteReader();
                Tablapersonas.Load(Resultadopersonas);
                return Tablapersonas;
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

        public List<Persona> ObtenerNombres()
        {
            OracleDataReader ResultadoNombre;
            List<Persona> Nombres = new List<Persona>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM V_NOMBRES_PERSONAS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoNombre = comando.ExecuteReader();

                while (ResultadoNombre.Read())
                {
                    Persona persona = new Persona();
                    persona.cedula = ResultadoNombre["cedula"].ToString();
                    persona.primernombre = ResultadoNombre["nombre"].ToString();
                    persona.primerapellido = ResultadoNombre["apellido"].ToString();
                    persona.telefono = ResultadoNombre["telefono"].ToString();
                    Nombres.Add(persona);
                }

                return Nombres;
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

        public List<Trabajador> ObtenerDatostrabajadores()
        {
            OracleDataReader Resultadodatos;
            List<Trabajador> datos = new List<Trabajador>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = ConexionPropietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM V_NOMBRES_CEDULAS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                Resultadodatos = comando.ExecuteReader();

                while (Resultadodatos.Read())
                {
                    Trabajador trabajador = new Trabajador();
                    trabajador.cedula = Resultadodatos["cedula"].ToString();
                    trabajador.primernombre = Resultadodatos["nombre"].ToString();
                    trabajador.primerapellido = Resultadodatos["apellido"].ToString();
                    trabajador.telefono = Resultadodatos["telefono"].ToString();
                    trabajador.cargo = Resultadodatos["cargo"].ToString();
                    trabajador.usuario = Resultadodatos["usuario"].ToString();
                    datos.Add(trabajador);
                }

                return datos;
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
    }
}
