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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectofactura
{        

    
    public partial class frmregistropropietario : Form
    {
        public frmregistropropietario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        Propietario propietario = new Propietario();
        ServicioPropierario servicioPropierario = new ServicioPropierario();
        ServicioCuenta Serviciocuenta = new ServicioCuenta();
        Cuenta cuenta = new Cuenta();


        private void tbcedulapropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el caracter si no es un dígito o una tecla de control (borrar, por ejemplo)
            }

        }

        private void tbtelefonopropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbnombrepropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el caracter si no es una letra o una tecla de control (borrar, por ejemplo)
            }
        }

        private void tbapellidopropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        
        private bool ValidarCamposNoVacios()
        {
            if (string.IsNullOrWhiteSpace(tbcedulapropietario.Text) ||
                string.IsNullOrWhiteSpace(tbnombrepropietario.Text) ||
                string.IsNullOrWhiteSpace(tbapellidopropietario.Text) ||
                string.IsNullOrWhiteSpace(tbtelefonopropietario.Text) ||
                string.IsNullOrWhiteSpace(tbusuariopropietario.Text) ||
                string.IsNullOrWhiteSpace(tbcontraseñapropietario.Text))
            {
                return false; 
            }
            return true; 
        }

        private void btregistropropietario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposNoVacios())
            
            {
                MessageBox.Show("Debe llenar todos los campos");
                return; 
            }
            else
            {
                Guardar();

                this.Close();
                frmingreso otroFormulario = new frmingreso();
                otroFormulario.Show();
            }  
        }

        private void obtenercuenta()
        {
            cuenta.usuario = tbusuariopropietario.Text;
            cuenta.contraseña = tbcontraseñapropietario.Text;
        }

        public void Guardar()
        {

            propietario.cedula = tbcedulapropietario.Text;
            propietario.primernombre = tbnombrepropietario.Text;
            propietario.primerapellido = tbapellidopropietario.Text;
            propietario.telefono = tbtelefonopropietario.Text;
            propietario.cargo = "PROPIETARIO";
            propietario.usuario = tbusuariopropietario.Text;
            obtenercuenta();

            string msg = servicioPropierario.InsertarAdministradores(propietario);
            string msg2 = Serviciocuenta.InsertarCuenta(cuenta);
            MessageBox.Show(msg);
            MessageBox.Show(msg2);
            this.Close();

        }
        private void tbcedulapropietario_Enter(object sender, EventArgs e)
        {
        }

        private void tbcedulapropietario_Leave(object sender, EventArgs e)
        {
        }

        private void tbnombrepropietario_Enter(object sender, EventArgs e)
        {
        }

        private void tbnombrepropietario_Leave(object sender, EventArgs e)
        {
        }

        private void tbapellidopropietario_Enter(object sender, EventArgs e)
        {
        }

        private void tbapellidopropietario_Leave(object sender, EventArgs e)
        {
        }

        private void tbtelefonopropietario_Enter(object sender, EventArgs e)
        {
        }
    }
}
