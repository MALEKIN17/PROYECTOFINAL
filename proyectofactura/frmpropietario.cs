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
    public partial class frmpropietario : Form
    {
        
        ServicioEmpleado empleados = new ServicioEmpleado();
        ServicioCuenta S_cuentas = new ServicioCuenta();
        string textoUsuario = "Cedula del empleado";
        Empleado empleado1 = new Empleado();
        public frmpropietario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
            tbbuscarempleado.Text = textoUsuario;
            cargarGrillaempleados();
            dtvempleados.Columns["contraseña"].Visible = false;

        }

        private void cargarGrillaempleados()
        {
            dtvempleados.DataSource = empleados.ObtenerTodosEmpleados();
            dtvempleados.Columns[0].Visible = false;
            dtvempleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cargar()
        {
            string Cedula_propietario = DatosCompartidos.ObtenerCedula();

            Trabajador trabajador1 = new Trabajador();

            trabajador1 = S_cuentas.ObtenerDatos(Cedula_propietario);

            lbcedulapropietario.Text = trabajador1.cedula;

            lbusuariopropietario.Text = trabajador1.usuario;

            lbtelefonopropietario.Text = trabajador1.telefono;
        }

        //private void Cargarpropietario()
        //{
        //    Trabajador trabajador1 = S_cuentas.ObtenerDatos(DatosCompartidos.ObtenerCedulaAdmin());

        //    // Verificar si se obtuvieron datos de la cuenta
        //    if (trabajador1 != null)
        //    {
        //        // Obtener los valores de las propiedades del objeto DatosUsuario
        //        lbcedulapropietario.Text = trabajador1.cedula;

        //        lbusuariopropietario.Text = trabajador1.usuario;

        //        lbtelefonopropietario.Text = trabajador1.telefono;
        //    }
        //}
        private void btcrearempleado_Click(object sender, EventArgs e)
        {
            
            frmregistroempleados nuevoForm = new frmregistroempleados();
            nuevoForm.Show();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmingreso nuevoForm = new frmingreso();
            nuevoForm.Show();
        }

        private void btgestionservicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmedicionservicios nuevoForm = new frmedicionservicios();
            nuevoForm.Show();
        }

        private void FiltrarDatos(string filtro)
        {
            List<Empleado> listaObjetos = empleados.ObtenerTodosEmpleados(); 

            List<Empleado> listaFiltrada = listaObjetos
                .Where(objeto => objeto.cedula.Contains(filtro)) 
                .ToList();

            // Asigna la lista filtrada al DataSource del DataGridView
            dtvempleados.DataSource = listaFiltrada;
        }

        private void tbbuscarempleado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarDatos(tbbuscarempleado.Text);
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dtvempleados_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void DatosParaLogearEmpleado(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvempleados.Rows[e.RowIndex];
                string emp_cedula = fila.Cells[0].Value.ToString();

                DatosCompartidos.ActualizarCedula(emp_cedula);


            }
        }

        private void CargarLogEmpleado()
        {
            string textoParaLabel = "ADMINISTRADOR";
            
            frmempleado frmLoginEmpleado = new frmempleado(textoParaLabel);
            frmLoginEmpleado.ShowDialog();
        }


        private void dtvempleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide(); 
            DatosParaLogearEmpleado(e);
            CargarLogEmpleado();
        }

        private void tbbuscarempleado_Enter(object sender, EventArgs e)
        {
            if (tbbuscarempleado.Text == textoUsuario)
            {
                tbbuscarempleado.Text = "";
            }
            dtvempleados.DataSource = empleados.ObtenerTodosEmpleados();
        }

        private void tbbuscarempleado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbbuscarempleado.Text))
            {
                tbbuscarempleado.Text = textoUsuario;
                
            }
            dtvempleados.DataSource = empleados.ObtenerTodosEmpleados();
        }
       
        private void eliminarcuenta()
        {

            string usuarioempleado = dtvempleados.CurrentRow.Cells[4].Value.ToString();
            
            if (dtvempleados.SelectedRows.Count > 0)
            {
                if (usuarioempleado != null)
                {
                    string ms1 = S_cuentas.EliminarCuenta(usuarioempleado);
                    MessageBox.Show(ms1);
                }
            }
        }

        private void EliminarEmpleado()
        {
            string cedula_cl = dtvempleados.CurrentRow.Cells[0].Value.ToString();
            if (dtvempleados.SelectedRows.Count > 0)
            {
                if (cedula_cl != null)
                {
                    string ms1= empleados.EliminarEmpleado(cedula_cl);
                   
                    MessageBox.Show(ms1);

                }
            }
        }
        private void bteliminarempleado_Click(object sender, EventArgs e)
        {

            try
            {
                if (dtvempleados.SelectedRows.Count > 0)
                {
                    eliminarcuenta();
                    EliminarEmpleado();
                   
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

        private void dtvempleados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dtvempleados.Rows[e.RowIndex];
            
            {
                empleado1.cedula = dtvempleados.CurrentRow.Cells[0].Value.ToString();
                empleado1.primernombre = dtvempleados.CurrentRow.Cells[1].Value.ToString();
                empleado1.primerapellido = dtvempleados.CurrentRow.Cells[2].Value.ToString();
                empleado1.telefono = dtvempleados.CurrentRow.Cells[3].Value.ToString();
                empleado1.usuario = dtvempleados.CurrentRow.Cells[4].Value.ToString();
                empleado1.cargo = dtvempleados.CurrentRow.Cells[6].Value.ToString();
            };
            var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                empleados.ActualizarEmpleado(empleado1);
                MessageBox.Show("datos actualizados");
                cargarGrillaempleados();
            }
            cargarGrillaempleados();
        }

        private void dtvempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
