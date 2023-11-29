using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public partial class ServicioServicio
    {
        GestionServicio G_Servisio = new GestionServicio();



        public string Insertarservicio(Servicio servicio)
        {
            string msg = G_Servisio.Insertarservicio(servicio);
            return msg;
        }


        public string Actualizarservicio(Servicio servicio)
        {
            string msg = G_Servisio.Actualizarservicio(servicio);
            return msg;
        }

        public Servicio Obtenerservicio(string cl_cedula)
        {
            List<Servicio> servicios = new List<Servicio>();
            servicios = G_Servisio.Consultarservicios();
            Servicio servicio = new Servicio();
            foreach (Servicio servicio1 in servicios)
            {
                if (servicio1.codigoservicio == cl_cedula)
                {
                    servicio = servicio1; break;
                }
            }
            return servicio;
        }

        public List<Servicio> ObtenerTodosServicios()
        {
            List<Servicio> servicios = new List<Servicio>();
            servicios = G_Servisio.Consultarservicios();
            return servicios;
        }

        public string Eliminarservicio(string p_id_factura)
        {
            string msg = G_Servisio.Eliminarservicio(p_id_factura);
            return msg;
        }
    }
}
