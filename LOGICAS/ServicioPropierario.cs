using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public  partial class ServicioPropierario
    {

        GestionPropietario G_Administradores = new GestionPropietario();
        


        public string InsertarAdministradores(Propietario propietario)
        {
            string msg1 = G_Administradores.Insertarpropietario(propietario);
            return msg1;
        }

        public string ActualizarAdministradores(Propietario propietario)
        {
            string msg2 = G_Administradores.Actualizarpropietario(propietario);
            return msg2;
        }

        public string EliminarAdministradores(string cedulapropietario)
        {
            string msg3 = G_Administradores.Eliminarpropietario(cedulapropietario);
            return msg3;
        }

        

        public List<Propietario> ListarAdministradores()
        {
            List<Propietario> lista = G_Administradores.Consultarpropietarios();
            return lista;
        }

       
    }
}
