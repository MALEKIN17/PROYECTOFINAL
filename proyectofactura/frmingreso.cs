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
    public partial class frmingreso : Form
    {

        ServicioCuenta S_cuentas = new ServicioCuenta();
        string tipo_cuenta;
        private string textoUsuario = "Usuario";
        private string textoContraseña = "Contraseña";
        private string textoClave = "Clave";

        
        public frmingreso()
        {
            InitializeComponent();

            tbusuario.Text = textoUsuario;
            tbcontraseña.Text = textoContraseña;
            tbclave.Text = textoClave;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tbusuario_Enter(object sender, EventArgs e)
        {
            if (tbusuario.Text == textoUsuario)
            {
                tbusuario.Text = "";
            }
        }

        private void tbusuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbusuario.Text))
            {
                tbusuario.Text = textoUsuario;
            }
        }

        private void tbcontraseña_Enter(object sender, EventArgs e)
        {
            if (tbcontraseña.Text == textoContraseña)
            {
                tbcontraseña.Text = "";
                tbcontraseña.PasswordChar = '*'; 
            }
        }

        private void tbcontraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbcontraseña.Text))
            {
                tbcontraseña.Text = textoContraseña;
                tbcontraseña.PasswordChar = '\0'; 
            }
        }

        private bool GestionInicio()
        {
            string usuario = tbusuario.Text;
            string contraseña = tbcontraseña.Text;
            DataTable tablaCuentas = S_cuentas.V_Cuentas();

            bool coinciden = false;
            tipo_cuenta = ""; // Variable para guardar el tipo de cuenta

            foreach (DataRow row in tablaCuentas.Rows)
            {
                string usuarioTabla = row["usuario"].ToString();
                string contraseñaTabla = row["contraseña"].ToString();

                if (usuario == usuarioTabla && contraseña == contraseñaTabla)
                {
                    coinciden = true;
                    DatosCompartidos.ActualizarCedula(row["cedula"].ToString());
                    tipo_cuenta = row["tipo_de_cuenta"].ToString(); // Obtener el tipo de cuenta de la fila actual
                    if (tipo_cuenta == "Administrador")
                    {
                        DatosCompartidos.ActualizarCedulaAdmin(row["cedula"].ToString());
                    }
                    break;
                }
            }

            return coinciden;
        }

        private void Inicio()
        {

            if (GestionInicio() == true && tipo_cuenta == "Administrador")
            {
                frmopcionvista frmLoginAdmin = new frmopcionvista();
                frmLoginAdmin.ShowDialog();
                this.Hide();
            }
            else
            {
                if (GestionInicio() == true && tipo_cuenta == "Empleado")
                {

                   AbrirFormDestino();
                }
                else
                {
                    
                    
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
                this.Show();
                    

                }

            }
        }

        private void AbrirFormDestino()
        {
            string textoParaLabel = "EMPLEADO";
            this.Hide();
            frmempleado empleadoForm = new frmempleado(textoParaLabel);

            empleadoForm.Show();
        }





        private void btingresar_Click(object sender, EventArgs e)
        {
            Inicio(); 
        }

        private void btregistrase_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string claveCorrecta = "1234"; 
            string claveIngresada = tbclave.Text;
            if (claveIngresada == claveCorrecta)
            {
                
                frmregistropropietario otroFormulario = new frmregistropropietario();
                otroFormulario.Show();
                
            }
            else
            {
                MessageBox.Show("Clave incorrecta. Por favor, intenta nuevamente.");
            }
        }

        private void tbclave_Enter(object sender, EventArgs e)
        {
            if (tbclave.Text == textoClave)
            {
                tbclave.Text = "";
                tbclave.PasswordChar = '*'; 
            }
        }

        private void tbclave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbclave.Text))
            {
                tbclave.Text = textoClave;
                tbclave.PasswordChar = '\0'; 
            }
        }
    }
}
