using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace frmPedidoCafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.Text = txtCliente.Text;
        }
        private void txtProducto_TextChanged(object sender, EventArgs e) { 
          txtProducto.Text.Any= txtProducto.Text;
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = txtCantidad.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0) { 
              ListViewItem item = lvCatalogo.SelectedItem[0];
                txtProducto.Text = item.Text;
                if (item.SubItems is decimal precio)
                {
                    precioSeleccionado = (decimal)precio;
                }
                else { 
                  string strPrecio = item.SubItems[1].Text.Replace("$", " ").Trim();
                    decimal.TryParse(strPrecio, System.Globalization.NumberStyles.Any);

                }
            }
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = lblTotal.Text + "%";
        }
    }
}
