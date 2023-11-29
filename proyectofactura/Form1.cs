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
    public partial class Form1 : Form
    {  
        ServicioServicio S_servicio = new ServicioServicio();
        ServicioCuenta S_cuentas = new ServicioCuenta();
        ServicioCliente S_cliente = new ServicioCliente();
        ServicioDetalle S_detalle = new ServicioDetalle();
        ServicioFactura S_factura = new ServicioFactura();
        ServicioVehiculo S_vehiculo = new ServicioVehiculo();
        Servicio servicio = new Servicio();
        Cliente cliente = new Cliente();
        Vehiculo vehiculo = new Vehiculo();
        Factura factura = new Factura();
        Detalle detalle = new Detalle();
        Empleado empleado = new Empleado();
        Trabajador trabajador1 = new Trabajador();

        private string textofiltro = "nombre del servicio";
        private Servicio objetoSeleccionado = null;
        private int sumaTotal = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tbfiltrodetalle.Text = textofiltro;
            ConfigurarDataGridView();
            cargar();
            dgvdetalles.CellClick += dgvdetalles_CellValueChanged;
        }

        private void tbfiltrodetalle_TextChanged(object sender, EventArgs e)
        {
            if (tbfiltrodetalle.Text != textofiltro)
            {
                dgvdetalles.DataSource = S_servicio.ObtenerTodosServicios().Where(x => x.descripcion.Contains(tbfiltrodetalle.Text)).ToList();
            }
        }

        private void tbfiltrodetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbfiltrodetalle.Text != textofiltro)
            {
                dgvdetalles.DataSource = S_servicio.ObtenerTodosServicios().Where(x => x.descripcion.Contains(tbfiltrodetalle.Text)).ToList();
            }
        }



        private void btgenerarfactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposNoVacios() || !ExisteAlgunaFilaSeleccionada())
                {
                    MessageBox.Show("Debe llenar todos los campos y Debe seleccionar al menos un servicio");
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
        private void ConfigurarDataGridView()
        {

            dgvdetalles.DataSource = S_servicio.ObtenerTodosServicios();// Asignar la lista de objetos al DataSource

            DataGridViewCheckBoxColumn columnaCheckBox = new DataGridViewCheckBoxColumn();
            columnaCheckBox.HeaderText = "Seleccionar";
            columnaCheckBox.Name = "cbSeleccionar";
            dgvdetalles.Columns.Add(columnaCheckBox);
            
        }


        private bool ValidarCamposNoVacios()
        {
            if (string.IsNullOrWhiteSpace(tbcedulacliente.Text) ||
                string.IsNullOrWhiteSpace(tbnombrecliente.Text) ||
                string.IsNullOrWhiteSpace(tbapellidocliente.Text) ||
                string.IsNullOrWhiteSpace(tbtelefonocliente.Text) ||
                string.IsNullOrWhiteSpace(tbplacavehiculo.Text) ||
                string.IsNullOrWhiteSpace(tbmodelovehiculo.Text) ||
                string.IsNullOrWhiteSpace(tbmarcavehiculo.Text))  
            {
                return false;
            }
            return true;
        }
        private bool ExisteAlgunaFilaSeleccionada()
        {
            foreach (DataGridViewRow fila in dgvdetalles.Rows)
            {
                DataGridViewCheckBoxCell checkbox = fila.Cells["cbSeleccionar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkbox?.Value) == true)
                {
                    return true; 
                }
            }
            return false; 
        }




        private void cargar()
        {
            string Cedula_propietario = DatosCompartidos.ObtenerCedula();
            trabajador1 = S_cuentas.ObtenerDatos(Cedula_propietario);
            lbcedulaempleado.Text = trabajador1.cedula;
            lbnombreempleado.Text = trabajador1.primernombre;
        }

        private void tbfiltrodetalle_Enter(object sender, EventArgs e)
        {
            if (tbfiltrodetalle.Text == textofiltro)
            {
                tbfiltrodetalle.Text = "";
            }
        }

        private void tbfiltrodetalle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbfiltrodetalle.Text))
            {
                tbfiltrodetalle.Text = textofiltro;
            }
        }
        private void obtenercliente()
        {
            cliente.cedula = tbcedulacliente.Text;
            cliente.primernombre = tbnombrecliente.Text;
            cliente.primerapellido = tbapellidocliente.Text;
            cliente.telefono = tbtelefonocliente.Text;

            string msg = S_cliente.Insertarcliente(cliente);
            MessageBox.Show(msg);

        }

        private void obtenervehiculo()
        {
            vehiculo.placa = tbplacavehiculo.Text;
            vehiculo.modelo = tbmodelovehiculo.Text;
            vehiculo.marca = tbmarcavehiculo.Text;
            vehiculo.cedulaCliente = cliente.cedula;

            string msg = S_vehiculo.Insertarvehiculo(vehiculo);
            MessageBox.Show(msg);
        }

        private void obtenerfactura()
        {
            string Cedula_propietario = DatosCompartidos.ObtenerCedula();
            Trabajador trabajador1 = new Trabajador();
            trabajador1 = S_cuentas.ObtenerDatos(Cedula_propietario);
            factura.cedulaCliente = cliente.cedula;
            factura.placa = vehiculo.placa;
            factura.cedulaempleado = trabajador1.cedula;
            factura.fecha = DateTime.Now;
            factura.preciototal = Convert.ToInt32(lbvalorfactura.Text);

            string msg = S_factura.InsertarFactura(factura);
            MessageBox.Show(msg);
        }

        private void obtenerdetalle()
        {
            foreach (DataGridViewRow fila in dgvdetalles.Rows)
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
        
        public void Guardar ()
        {
            obtenercliente();
            obtenervehiculo();
            obtenerfactura();
            obtenerdetalle();


        }
        



        private void btgenerarfactura_Click_1(object sender, EventArgs e)
        {
            
            
        }


        private void dgvdetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && dgvdetalles.Columns[e.ColumnIndex].Name == "cbSeleccionar" && e.RowIndex >= 0)
            {
                int suma = 0;


                foreach (DataGridViewRow fila in dgvdetalles.Rows)
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
        


        private void RecalcularSuma()
        {
            int suma = 0;

            foreach (DataGridViewRow fila in dgvdetalles.Rows)
            {
                DataGridViewCheckBoxCell checkbox = fila.Cells["cbSeleccionar"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkbox?.Value) == true)
                {
                    // Acceder al atributo 'Valor' del objeto asociado a la fila y sumarlo
                    Servicio objeto = fila.DataBoundItem as Servicio; // Reemplaza 'Objeto' por el nombre de tu clase
                    suma=suma += objeto.precio;
                }else
                {
                    Servicio objeto = fila.DataBoundItem as Servicio; // Reemplaza 'Objeto' por el nombre de tu clase
                    suma=suma -= objeto.precio;
                }
            }

            // Mostrar la suma total en el Label
            lbvalorfactura.Text = Convert.ToString(suma);
        }

        private void dgvdetalles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgvdetalles.Columns[e.ColumnIndex].Name == "cbSeleccionar") // Reemplaza "Seleccionar" con el nombre de la columna de checkboxes
                {
                    RecalcularSuma();
                }
            }
        }

        private void dgvdetalles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void dgvdetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
