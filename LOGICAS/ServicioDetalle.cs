using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public partial class ServicioDetalle
    {

        GestionDetalle G_detalles = new GestionDetalle();



        public string Insertardetalle(Detalle detalle)
        {
            string msg = G_detalles.Insertardetalle(detalle);
            return msg;
        }


        public string Actualizardetalle(Detalle detalle)
        {
            string msg = G_detalles.Actualizardetalle(detalle);
            return msg;
        }

        public List<Detalle> Obtenerdetalles(string cod_factura)
        {
            List<Detalle> Detalles = new List<Detalle>();
            Detalles = G_detalles.Consultardetalles();
            List<Detalle> Detallesfactura = new List<Detalle>();
            foreach (Detalle detalle1 in Detalles)
            {
                if (detalle1.numerofactura == cod_factura)
                {

                    Detallesfactura.Add(detalle1); 
                }
            }
            return Detallesfactura;
        }
        

        public List<Detalle> ObtenerTodosDetalles()
        {
            List<Detalle> Detalles = new List<Detalle>();
            Detalles = G_detalles.Consultardetalles();
            return Detalles;
        }

        


        public string Eliminardetalle(int p_cog_detalle)
        {
            string msg = G_detalles.Eliminardetalle(p_cog_detalle.ToString());
            return msg;
        }

    }
}
