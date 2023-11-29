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
    public partial class frmregistroservicio : Form
    {
        Servicio servicio= new Servicio();
        ServicioServicio servicioServicio = new ServicioServicio();
        public frmregistroservicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void Guardar()
        {
            servicio.descripcion = tbnombreservicio.Text;
            servicio.precio = Convert.ToInt32(tbprecioservicio.Text);
            string msg = servicioServicio.Insertarservicio(servicio);
            MessageBox.Show(msg);
            

        }
        private bool ValidarCamposNoVacios()
        {
            if (string.IsNullOrWhiteSpace(tbnombreservicio.Text) ||
                               string.IsNullOrWhiteSpace(tbprecioservicio.Text))
            {
                return false;
            }
            return true;
        }
        private void btregistrarservicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposNoVacios())

                {
                    MessageBox.Show("Debe llenar todos los campos");
                    return;
                }else
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
    }
}
