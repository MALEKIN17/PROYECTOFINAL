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
    
    public partial class frmfacturascliente : Form
    {
        string textobuscar = "numero de la factura";
        ServicioFactura ServicioFactura = new ServicioFactura();
        Factura Factura = new Factura();
        Cliente Cliente1 = new Cliente();
        
        public frmfacturascliente(Cliente cliente)
        {
            InitializeComponent();
            Cliente1 = cliente;
            this.StartPosition = FormStartPosition.CenterScreen;
            tbbuscarfactura.Text = textobuscar;
            cargargrillafacturas();

        }


        private void FiltrarDatos(string filtro)
        {
            List<Factura> listaObjetos = ServicioFactura.ObtenerTodasFacturas();

            List<Factura> listaFiltrada = listaObjetos
                .Where(objeto => objeto.numerofactura.Contains(filtro))
                .ToList();

            // Asigna la lista filtrada al DataSource del DataGridView
            dtgfacturascliente.DataSource = listaFiltrada;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarDatos(tbbuscarfactura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void cargargrillafacturas()
        {
            dtgfacturascliente.DataSource = ServicioFactura.Obtenerfacturascliente(Cliente1.cedula);
            dtgfacturascliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void tbbuscarfactura_Enter(object sender, EventArgs e)
        {

            if (tbbuscarfactura.Text == textobuscar)
            {
                tbbuscarfactura.Text = "";
            }
            cargargrillafacturas();
        }

        private void tbbuscarfactura_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbbuscarfactura.Text))
            {
                tbbuscarfactura.Text = textobuscar;

            }
            cargargrillafacturas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgfacturascliente_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //var fila = dtgfacturascliente.Rows[e.RowIndex];

            //{
            //    Factura.numerofactura = dtgfacturascliente.CurrentRow.Cells[0].Value.ToString();
            //    Factura.cedulaCliente = dtgfacturascliente.CurrentRow.Cells[2].Value.ToString();
            //    Factura.fecha = Convert.ToDateTime(dtgfacturascliente.CurrentRow.Cells[1].Value.ToString());
            //    Factura.preciototal = Convert.ToInt32(dtgfacturascliente.CurrentRow.Cells[3].Value.ToString());
            //    Factura.cedulaempleado = dtgfacturascliente.CurrentRow.Cells[4].Value.ToString();

                
            //};
            //var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (respuesta == DialogResult.Yes)
            //{
            //    ServicioFactura.ActualizarFactura(Factura);
            //    MessageBox.Show("datos actualizados");
            //    cargargrillafacturas();
            //}
            //cargargrillafacturas();
        }

        private void dtgfacturascliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string codigodactura = dtgfacturascliente.CurrentRow.Cells[0].Value.ToString();
                if (dtgfacturascliente.SelectedRows.Count > 0)
                {
                    if (codigodactura != null)
                    {

                        Factura = ServicioFactura.ObtFactura(codigodactura);

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
            frmfactura nuevoForm = new frmfactura(Factura);
            nuevoForm.Show();
        }
    }
}
