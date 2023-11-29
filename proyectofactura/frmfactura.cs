using ENTIDADES;
using LOGICAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofactura
{
    public partial class frmfactura : Form
    {

        Cliente cliente = new Cliente();
        Trabajador trabajador = new Trabajador();
        
        Vehiculo vehiculo = new Vehiculo();
        ServicioVehiculo servicioVehiculo = new ServicioVehiculo();
        ServicioCliente servicioCliente = new ServicioCliente();
        ServicioDetalle servicioDetalle = new ServicioDetalle();
        ServicioEmpleado servicioEmpleado = new ServicioEmpleado();
        ServicioReporte Servicioreporte = new ServicioReporte();
        Factura factura1 = new Factura();
        public frmfactura(Factura factura)
        {
            InitializeComponent();
            factura1 = factura;
            cargar();
            dtgdetalles.DataSource = servicioDetalle.Obtenerdetalles(factura1.numerofactura);
            dtgdetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgdetalles.Columns["codigoservicio"].Visible = false;
        }
        private void cargar()
        {
            
            lbfechafactura.Text = factura1.fecha.ToString();
            lbvalorfactura.Text = factura1.preciototal.ToString();
            cargarcliente();
            cargarempleado();
            cargarvehiculo();
            
        }
        private void cargarvehiculo()
        {
            vehiculo = servicioVehiculo.Obtenervehiculo(factura1.placa);
            lbplacavehiculo.Text = vehiculo.placa;
            lbmarcavehiculo.Text = vehiculo.marca;
            lbmodelovehiculo.Text = vehiculo.modelo;
        }

        private void cargarempleado()
        {
            
            trabajador = servicioEmpleado.ObtenerDatosEmpleado(factura1.cedulaempleado);
            lbnombreempleado.Text = trabajador.primernombre;
            lbcedulaempleado.Text = trabajador.cedula;  
        }
        private void cargarcliente()
        {
            
            cliente = servicioCliente.Obtenercliente(factura1.cedulaCliente);

            lbcedulacliente.Text = cliente.cedula;
            lbnombrecliente.Text = cliente.primernombre;
            lbapellidocliente.Text = cliente.primerapellido;
            lbtelefonocliente.Text = cliente.telefono;


        }

        private void GenerarPdf()
        {

            string nombrePDF = "FACTURA " + factura1.numerofactura.ToString();
            List<Detalle> listaDetalles = servicioDetalle.Obtenerdetalles(factura1.numerofactura);
            Servicioreporte.GenerarPDFFactura(factura1,listaDetalles, nombrePDF);

            
            string rutaPDF = nombrePDF + ".pdf";
            System.Diagnostics.Process.Start(rutaPDF);

        }
        private void btgenerarpdf_Click(object sender, EventArgs e)
        {
            GenerarPdf();
        }

        private void dtgdetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
