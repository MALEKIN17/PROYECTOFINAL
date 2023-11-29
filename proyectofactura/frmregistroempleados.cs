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
    public partial class frmregistroempleados : Form
    {
         Empleado empleado = new Empleado();
        Cuenta cuenta = new Cuenta();
        ServicioEmpleado servicioempleado = new ServicioEmpleado();
        ServicioCuenta Serviciocuenta = new ServicioCuenta();
        public frmregistroempleados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool ValidarCamposNoVacios()
        {
            if (string.IsNullOrWhiteSpace(tbcedulaempleado.Text) ||
                string.IsNullOrWhiteSpace(tbnombreempleado.Text) ||
                string.IsNullOrWhiteSpace(tbapellidoempleado.Text) ||
                string.IsNullOrWhiteSpace(tbtelefonoempleado.Text) ||
                string.IsNullOrWhiteSpace(tbusuarioempleado.Text) ||
                string.IsNullOrWhiteSpace(tbcontraseñaempleado.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposNoVacios())

            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            Guardar();

            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void obtenercuenta()
        {
            cuenta.usuario = tbusuarioempleado.Text;
            cuenta.contraseña = tbcontraseñaempleado.Text;
        }
        public void Guardar()
        {

            empleado.cedula = tbcedulaempleado.Text;
            empleado.primernombre = tbnombreempleado.Text;
            empleado.primerapellido = tbapellidoempleado.Text;
            empleado.telefono = tbtelefonoempleado.Text;
            empleado.cargo = "EMPLEADO";
            empleado.usuario = tbusuarioempleado.Text;
            obtenercuenta();
            string msg2 = Serviciocuenta.InsertarCuenta(cuenta);
            string msg = servicioempleado.InsertarEmpleado(empleado);
            
            MessageBox.Show(msg);
            MessageBox.Show(msg2);
            this.Close();

        }

        private void tbcedulaempleado_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbcedulaempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbnombreempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbapellidoempleado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbtelefonoempleado_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbusuarioempleado_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbcontraseñaempleado_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
