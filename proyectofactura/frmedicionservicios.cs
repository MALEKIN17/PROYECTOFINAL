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
    public partial class frmedicionservicios : Form
    {   
        Servicio Servicio = new Servicio();
        ServicioServicio S_servicio = new ServicioServicio();
        ServicioCuenta S_cuentas = new ServicioCuenta();
        string textosevicio = "nombre del servicio";
        public frmedicionservicios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
            tbbuscarservicio.Text = textosevicio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmpropietario nuevoForm = new frmpropietario();
            nuevoForm.Show();
        }

        private void btcrearservicio_Click(object sender, EventArgs e)
        {
            
            frmregistroservicio nuevoForm = new frmregistroservicio();
            nuevoForm.Show();
        }

        private void cargargrillaservicios()
        {
            dgvservicios.DataSource = S_servicio.ObtenerTodosServicios();
            dgvservicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmingreso nuevoForm = new frmingreso();
            nuevoForm.Show();
        }
        private void FiltrarDatos(string filtro)
        {
            List<Servicio> listaObjetos = S_servicio.ObtenerTodosServicios();

            List<Servicio> listaFiltrada = listaObjetos
                .Where(objeto => objeto.descripcion.Contains(filtro))
                .ToList();

            
            dgvservicios.DataSource = listaFiltrada;
        }
        
        private void tbbuscarservicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarDatos(tbbuscarservicio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbbuscarservicio_Enter(object sender, EventArgs e)
        { if (tbbuscarservicio.Text == textosevicio)
            {
                tbbuscarservicio.Text = "";
            }
            dgvservicios.DataSource = S_servicio.ObtenerTodosServicios();

        }

        private void tbbuscarservicio_Leave(object sender, EventArgs e)

        { if (string.IsNullOrWhiteSpace(tbbuscarservicio.Text))
            {
                tbbuscarservicio.Text = textosevicio;
            }
            dgvservicios.DataSource = S_servicio.ObtenerTodosServicios();

        }
        private void Eliminarservicio()
        {
            string id_servicio = dgvservicios.CurrentRow.Cells[0].Value.ToString();
            if (dgvservicios.SelectedRows.Count > 0)
            {
                if (id_servicio != null)
                {
                    string ms1 = S_servicio.Eliminarservicio(id_servicio);

                    MessageBox.Show(ms1);

                }
            }
        }
        private void btborrarservicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvservicios.SelectedRows.Count > 0)
                {
                    Eliminarservicio();

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

        private void dgvservicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvservicios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var fila = dgvservicios.Rows[e.RowIndex];

                Servicio.codigoservicio = dgvservicios.CurrentRow.Cells[0].Value.ToString();
                Servicio.descripcion = dgvservicios.CurrentRow.Cells[1].Value.ToString();
                Servicio.precio = Convert.ToInt32(dgvservicios.CurrentRow.Cells[2].Value.ToString());


                var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    S_servicio.Actualizarservicio(Servicio);
                    MessageBox.Show("datos actualizados");
                    cargargrillaservicios();
                }
                cargargrillaservicios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        
    }
}


