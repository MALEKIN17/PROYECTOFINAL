using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class BasedatosORACLE
    {

        protected OracleConnection conexion = null;    // = new OracleConnection();
        protected string cadena = "user id=propietario1;password=oracle;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=localhost)(PORT=1521))(CONNECT_DATA=" +
                                "(SERVICE_NAME=XE)))";

        public BasedatosORACLE()
        {
            conexion = new OracleConnection(cadena);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
