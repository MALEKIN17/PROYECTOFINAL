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
    public partial class frmopcionvista : Form
    {
        public frmopcionvista()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmpropietario propietarioForm = new frmpropietario();
            propietarioForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormDestino();
        }

        private void AbrirFormDestino()
        {
            string textoParaLabel = "ADMINISTRADOR"; 
            this.Close();
            frmempleado empleadoForm = new frmempleado(textoParaLabel);
            
            empleadoForm.Show();
        }
    }
}
