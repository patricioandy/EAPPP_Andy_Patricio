using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            bool hayNombre = !string.IsNullOrWhiteSpace(txtCliente.Text);
            lvCatalogo.Enabled = hayNombre;

            if (hayNombre)
            {
                if (lvCatalogo.SelectedItems.Count == 0)
                    lbEstado.Text = "Estado: Seleccione un producto";
            }
            else
            {
                lvCatalogo.SelectedItems.Clear();
                txtProducto.Clear();
                lbEstado.Text = "Estado: Ingrese el nombre del cliente";
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e) {
            bool cantidadValida = int.TryParse(txtCantidad.Text.Trim(), out int cantidad) && cantidad > 0;

            rbtnMostrador.Enabled = cantidadValida;
            rbtnEntrega.Enabled = cantidadValida;

            if (!cantidadValida)
            {
                rbtnMostrador.Checked = false;
                rbtnEntrega.Checked = false;
            }
        }
        /*
        private void txtProducto_TextChanged(object sender, EventArgs e) { 
          txtProducto.Text.Any= txtProducto.Text;
        }
        
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = txtCantidad.Text;
        }
        */
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                txtProducto.Text = lvCatalogo.SelectedItems[0].Text;
            }
            else
            {
                txtProducto.Clear();
            }
        }
        
        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = lblTotal.Text + "%";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lvCatalogo.Enabled = false;
            rbtnMostrador.Enabled = false;
            rbtnEntrega.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            btnLimpiar.Enabled = false;
            lbEstado.Text = "Estado: Ingrese el nombre del cliente";

            lvPedido.View = View.Details;
            if (lvPedido.Columns.Count == 0)
            {
                lvPedido.Columns.Add("Producto", 160);
                lvPedido.Columns.Add("Cantidad", 80);
                lvPedido.Columns.Add("Subtotal", 100);
            }
        }
        private void rbtnOpcion_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = rbtnMostrador.Checked || rbtnEntrega.Checked;
        }
        private void RecalcularTotal()
        {
            double total = 0;
            foreach (ListViewItem fila in lvPedido.Items)
            {
                total += double.Parse(fila.SubItems[2].Text, CultureInfo.InvariantCulture);
            }
            lblTotal.Text = "Total: $" + total.ToString("0.00", CultureInfo.InvariantCulture);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count == 0) return;
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0) return;

            ListViewItem itemCatalogo = lvCatalogo.SelectedItems[0];
            string producto = itemCatalogo.Text;

            string textoPrecio = itemCatalogo.SubItems[1].Text.Trim();
            double.TryParse(
                textoPrecio,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double precioUnitario
            );

            double subtotal = precioUnitario * cantidad;

            ListViewItem filaResumen = new ListViewItem(producto);
            filaResumen.SubItems.Add(cantidad.ToString());
            filaResumen.SubItems.Add(subtotal.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));

            lvPedido.Items.Add(filaResumen);
            RecalcularTotal();

            // 
            btnQuitar.Enabled = true;
            btnLimpiar.Enabled = true;

            // 
            lvCatalogo.SelectedItems.Clear();
            txtCantidad.Clear();
            lbEstado.Text = "Estado: Seleccione un producto";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres borrar todo el pedido?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No) return;

            lvPedido.Items.Clear();
            lvCatalogo.SelectedItems.Clear();
            txtCantidad.Clear();
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            txtCliente.Clear();

            RecalcularTotal();
            btnQuitar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una fila del pedido para quitarla.");
                return;
            }

            lvPedido.Items.Remove(lvPedido.SelectedItems[0]);
            RecalcularTotal();

            if (lvPedido.Items.Count == 0)
            {
                btnQuitar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
        }
    }
}
