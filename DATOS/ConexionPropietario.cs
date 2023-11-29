using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ConexionPropietario
    {
        private static ConexionPropietario conn = null;

        public ConexionPropietario()
        {

        }

        public OracleConnection CrearConexion()
        {
            OracleConnection Cadena = new OracleConnection();

            try
            {
                Cadena.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                          ";User Id=propietario2;Password=oracle;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static ConexionPropietario ObtenerInstancia()
        {
            if (conn == null)
            {
                conn = new ConexionPropietario();
            }
            return conn;
        }
    }
}
