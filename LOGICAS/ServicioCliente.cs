using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public partial class ServicioCliente
    {

        GestionCliente G_clientes = new GestionCliente();



        public string Insertarcliente(Cliente cliente)
        {
            string msg = G_clientes.Insertarcliente(cliente);
            return msg;
        }


        public string Actualizarcliente(Cliente cliente)
        {
            string msg = G_clientes.Actualizarcliente(cliente);
            return msg;
        }

        public Cliente Obtenercliente(string cl_cedula)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = G_clientes.Consultarclientes();
            Cliente cliente = new Cliente();
            foreach (Cliente cliente1 in clientes)
            {
                if (cliente1.cedula == cl_cedula)
                {
                    cliente = cliente1; break;
                }
            }
            return cliente;
        }

        public List<Cliente> ObtenerTodosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = G_clientes.Consultarclientes();
            return clientes;
        }

        public string Eliminarcliente(string p_cc_cliente)
        {
            string msg = G_clientes.Eliminarcliente(p_cc_cliente);
            return msg;
        }
    }
}
