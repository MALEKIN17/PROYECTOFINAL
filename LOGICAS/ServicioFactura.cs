using DATOS;
using ENTIDADES;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public partial class ServicioFactura
    {
        GestionFactura G_factura = new GestionFactura();
        GestionInicio G_Inicio = new GestionInicio();  


        

        public string InsertarFactura(Factura factura)
        {
            string msg = G_factura.Insertarfactura(factura);
            return msg;
        }

       
        public string ActualizarFactura(Factura factura)
        {
            string msg = G_factura.Actualizarfactura(factura);
            return msg;
        }

        public Factura ObtFactura(string cl_codigo)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = G_factura.Consultarfacturas();
            Factura factura = new Factura();
            foreach (Factura fact in facturas)
            {
                if (fact.numerofactura == cl_codigo)
                {
                    factura = fact; break;
                }
            }
            return factura;
        }
        public Factura Obtenerfacturacliente(string cedulacliente)
        {

            List<Factura> facturas = new List<Factura>();
            facturas = G_factura.Consultarfacturas();
            Factura factura = new Factura();
            foreach (Factura fact in facturas)
            {
                if (fact.cedulaCliente == cedulacliente)
                {
                    factura = fact; break;
                }
            }
            return factura;
        }
        public List<Factura> ObtenerTodasFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            facturas = G_factura.Consultarfacturas();
            return facturas;
        }
        

        public List<Factura> Obtenerfacturascliente(string cedulacliente)
        {
            
            List<Factura> facturas = new List<Factura>();
            facturas = G_factura.Consultarfacturas();
            List<Factura> facturascliente = new List<Factura>();
            foreach (Factura fact in facturas)
            {
                if (fact.cedulaCliente == cedulacliente)
                {
                    facturascliente.Add(fact);
                }
            }
            return facturascliente;
        }




        public string EliminarFactura(int p_id_factura)
        {
            string msg = G_factura.Eliminarfactura(p_id_factura.ToString());
            return msg;
        }

        
    }
}
