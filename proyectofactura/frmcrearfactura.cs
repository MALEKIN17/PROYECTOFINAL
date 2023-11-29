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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proyectofactura
{
    public partial class frmcrearfactura : Form
    {
        Cliente cliente1 = new Cliente();
        Trabajador trabajador1 = new Trabajador();
        ServicioCliente servicioCliente = new ServicioCliente();
        Vehiculo vehiculo = new Vehiculo();
        ServicioVehiculo servicioVehiculo = new ServicioVehiculo();
        ServicioServicio Servicioservicio = new ServicioServicio();
        Factura factura = new Factura();
        ServicioFactura S_factura = new ServicioFactura();
        ServicioDetalle S_detalle = new ServicioDetalle();
        
        Detalle detalle = new Detalle();
        public frmcrearfactura(Cliente cliente,Trabajador trabajador)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cliente1= cliente;
            trabajador1 = trabajador;
            establecernoedicion();
            cargartodo();
        }

        private void establecernoedicion()
        {
            tbcedulacliente.ReadOnly = true;
            tbcedulaempleado.ReadOnly = true;
            tbnombreempleado.ReadOnly = true;
            tbnombrecliente.ReadOnly = true;
            tbapellidocliente.ReadOnly = true;
            tbtelefonocliente.ReadOnly = true;
            tbplacavehiculo.ReadOnly = true;
            tbmodelovehiculo.ReadOnly = true;
            tbmarcavehiculo.ReadOnly = true;

        }
        private void cargartodo()
        {
            cargargrilla();
            cargarempleadocliente();
            cargarvehiculo();
        }
        private void cargargrilla()
        {
            dtgservicios.DataSource = Servicioservicio.ObtenerTodosServicios();

            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.HeaderText = "Seleccionar";
            columnaCheckBox.Name = "cbSeleccionar";
            dtgservicios.Columns.Add(columnaCheckBox);
        }
        private void cargarempleadocliente()
        {
            tbcedulacliente.Text=cliente1.cedula;
            tbnombrecliente.Text=cliente1.primernombre;
            tbapellidocliente.Text=cliente1.primerapellido;
            tbtelefonocliente.Text=cliente1.telefono;

            tbcedulaempleado.Text = trabajador1.cedula;
            tbnombreempleado.Text = trabajador1.primernombre;
        }
        private void cargarvehiculo()
        {
            vehiculo= servicioVehiculo.Obtenervehiculocliente(cliente1.cedula);
            tbplacavehiculo.Text = vehiculo.placa;
            tbmarcavehiculo.Text = vehiculo.marca;
            tbmodelovehiculo.Text = vehiculo.modelo;
        }

        public void Guardar()
        {
            obtenerfactura();
            obtenerdetalle();


        }

        

       

        private void obtenerfactura()
        {
            factura.cedulaCliente = cliente1.cedula;
            factura.placa = vehiculo.placa;
            factura.cedulaempleado = trabajador1.cedula;
            factura.fecha = DateTime.Now;
            factura.preciototal = Convert.ToInt32(lbvalorfactura.Text);

            string msg = S_factura.InsertarFactura(factura);
            MessageBox.Show(msg);
        }

        private void obtenerdetalle()
        {
            foreach (DataGridViewRow fila in dtgservicios.Rows)
            {
                DataGridViewCheckBoxCell checkbox = fila.Cells["cbSeleccionar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkbox.Value) == true)
                {
                    string cedulacliente = tbcedulacliente.Text;
                    Factura factura1 = new Factura();
                    factura1 = S_factura.Obtenerfacturacliente(cedulacliente);
                    detalle.numerofactura = factura1.numerofactura;
                    detalle.descripcion = fila.Cells["descripcion"].Value.ToString();
                    detalle.precio = Convert.ToInt32(fila.Cells["precio"].Value);
                    string msg = S_detalle.Insertardetalle(detalle);
                    MessageBox.Show(msg);
                }
            }
        }

        private bool ExisteAlgunaFilaSeleccionada()
        {
            foreach (DataGridViewRow fila in dtgservicios.Rows)
            {
                DataGridViewCheckBoxCell checkbox = fila.Cells["cbSeleccionar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkbox?.Value) == true)
                {
                    return true;
                }
            }
            return false;
        }
        //private bool ValidarCamposNoVacios()
        //{
        //    if (string.IsNullOrWhiteSpace(tbcedulacliente.Text) ||
        //        string.IsNullOrWhiteSpace(tbnombrecliente.Text) ||
        //        string.IsNullOrWhiteSpace(tbapellidocliente.Text) ||
        //        string.IsNullOrWhiteSpace(tbtelefonocliente.Text) ||
        //        string.IsNullOrWhiteSpace(tbplacavehiculo.Text) ||
        //        string.IsNullOrWhiteSpace(tbmodelovehiculo.Text) ||
        //        string.IsNullOrWhiteSpace(tbmarcavehiculo.Text))
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        private void btconfirmarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ExisteAlgunaFilaSeleccionada())
                {
                    MessageBox.Show( "Debe seleccionar al menos un servicio");
                    return;

                }
                else
                {
                    Guardar();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgservicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && dtgservicios.Columns[e.ColumnIndex].Name == "cbSeleccionar" && e.RowIndex >= 0)
            {
                int suma = 0;


                foreach (DataGridViewRow fila in dtgservicios.Rows)
                {
                    DataGridViewCheckBoxCell checkbox = fila.Cells["cbSeleccionar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkbox.Value) == true)
                    {
                        int valor = Convert.ToInt32(fila.Cells["precio"].Value);

                        suma += valor;
                    }


                }


                lbvalorfactura.Text = suma.ToString();
            }
        }
    }
}
