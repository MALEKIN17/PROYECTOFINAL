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
    public partial class frmempleado : Form
    {

        ServicioCliente clientes = new ServicioCliente();
        ServicioCuenta S_cuentas = new ServicioCuenta();
        ServicioVehiculo Serviciovehiculo = new ServicioVehiculo();
        Cliente cliente1 = new Cliente();
        Trabajador trabajador1 = new Trabajador();
        string textoUsuario = "cedula del cliente";
        
        public frmempleado(string texto)
        {
            InitializeComponent();
            lbrol.Text = texto;
            this.StartPosition = FormStartPosition.CenterScreen;
            tbbuscarusuario.Text = textoUsuario;
            cargar();
        }

        private void cargar()
        {
            dgvclientes.DataSource = clientes.ObtenerTodosClientes();
            string Cedula_empleado = DatosCompartidos.ObtenerCedula();
            trabajador1 = S_cuentas.ObtenerDatos(Cedula_empleado);
            lbcedulaempleado.Text = trabajador1.cedula;
            lbusuarioempleado.Text = trabajador1.usuario;
            lbtelefonoempleado.Text = trabajador1.telefono;
            lbrol.Text = trabajador1.cargo;
        }

        //private void Cargarpropietario()
        //{
        //    Trabajador trabajador1 = S_cuentas.ObtenerDatos(DatosCompartidos.ObtenerCedulaAdmin());

        //    // Verificar si se obtuvieron datos de la cuenta
        //    if (trabajador1 != null)
        //    {
        //        // Obtener los valores de las propiedades del objeto DatosUsuario
        //        lbcedulaempleado.Text = trabajador1.cedula;
        //        lbusuarioempleado.Text = trabajador1.usuario;
        //        lbtelefonoempleado.Text = trabajador1.telefono;
        //        lbrol.Text = trabajador1.cargo;
        //    }
        //}


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmingreso nuevoForm = new frmingreso();
            nuevoForm.Show();
        }

        private void btcrearfactura_Click(object sender, EventArgs e)
        {
            
            Form1 nuevoForm = new Form1();
            nuevoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente1.cedula = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            cliente1=clientes.Obtenercliente(cliente1.cedula);
            frmcrearfactura nuevoForm = new frmcrearfactura(cliente1,trabajador1);
            nuevoForm.Show();
        }
        private void FiltrarDatos(string filtro)
        {
            List<Cliente> listaObjetos = clientes.ObtenerTodosClientes();

            List<Cliente> listaFiltrada = listaObjetos
                .Where(objeto => objeto.cedula.Contains(filtro))
                .ToList();

            // Asigna la lista filtrada al DataSource del DataGridView
            dgvclientes.DataSource = listaFiltrada;
        }
        private void tbbuscarusuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarDatos(tbbuscarusuario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
        private void tbbuscarusuario_Enter(object sender, EventArgs e)
        {
            if (tbbuscarusuario.Text == textoUsuario)
            {
                tbbuscarusuario.Text = "";
            }
            dgvclientes.DataSource = clientes.ObtenerTodosClientes();
        }

        private void tbbuscarusuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbbuscarusuario.Text))
            {
                tbbuscarusuario.Text = textoUsuario;
            }
            dgvclientes.DataSource = clientes.ObtenerTodosClientes();
        }

       

        private void ObtenerObjetoSeleccionado()
        {
           
        }
        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string CEDULACLIENTE = dgvclientes.CurrentRow.Cells[0].Value.ToString();
                if (dgvclientes.SelectedRows.Count > 0)
                {
                    if (CEDULACLIENTE != null)
                    {

                        cliente1 = clientes.Obtenercliente(CEDULACLIENTE);

                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar antes una fila para eliminar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmfacturascliente nuevoForm = new frmfacturascliente(cliente1);
            nuevoForm.Show();
        }
        private void eliminarcliente()
        {
            string cedula_cliente = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            if (dgvclientes.SelectedRows.Count > 0)
            {
                if (cedula_cliente != null)
                {
                    string ms1 = clientes.Eliminarcliente(cedula_cliente);

                    MessageBox.Show(ms1);

                }
            }
        }

        private void eliminarvehiculos()
        {
            string cedula_cliente = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            if (dgvclientes.SelectedRows.Count > 0)
            {
                if (cedula_cliente != null)
                {
                    string ms1 = Serviciovehiculo.Eliminarvehiculo(cedula_cliente);

                    MessageBox.Show(ms1);

                }
            }
        }

        private void cargargrillaclientes()
        {
            dgvclientes.DataSource = clientes.ObtenerTodosClientes();

            dgvclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btborrarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvclientes.SelectedRows.Count > 0)
                {

                    eliminarcliente();
                    eliminarvehiculos();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar antes una fila para eliminar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvclientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                cliente1.cedula = dgvclientes.CurrentRow.Cells[0].Value.ToString();
                cliente1.primernombre = dgvclientes.CurrentRow.Cells[1].Value.ToString();
                cliente1.primerapellido = dgvclientes.CurrentRow.Cells[2].Value.ToString();
                cliente1.telefono = dgvclientes.CurrentRow.Cells[3].Value.ToString();
            
            var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                clientes.Actualizarcliente(cliente1);
                MessageBox.Show("datos actualizados");
                
            }
            
        }
    }
}
