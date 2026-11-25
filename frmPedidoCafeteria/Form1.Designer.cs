namespace frmPedidoCafeteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader Producto;
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem(new string[] {
            "Empanada de queso",
            "1.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sánduche de pollo",
            "2.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bolón de verde mixto",
            "2.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem(new string[] {
            "Humita Tradicional",
            "1.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem(new string[] {
            "tostada con queso",
            "1.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem(new string[] {
            "Café pasado",
            "0.85"}, -1);
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem(new string[] {
            "Chocolate Caliente",
            "1.35"}, -1);
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jugo natural (naranja/mora)",
            "1.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem(new string[] {
            "Batido de fruta",
            "2.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "Botella de agua",
            "0.50"}, -1);
            this.lvPedido = new System.Windows.Forms.ListView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblCatalogoProducto = new System.Windows.Forms.Label();
            this.lblDetallePedido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 176;
            // 
            // lvPedido
            // 
            this.lvPedido.FullRowSelect = true;
            this.lvPedido.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(756, 80);
            this.lvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.lvPedido.MultiSelect = false;
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(272, 296);
            this.lvPedido.TabIndex = 3;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            this.lvPedido.View = System.Windows.Forms.View.Details;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(351, 85);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(359, 22);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(8, 23);
            this.rbtnMostrador.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(146, 20);
            this.rbtnMostrador.TabIndex = 1;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            this.rbtnMostrador.CheckedChanged += new System.EventHandler(this.rbtnOpcion_CheckedChanged);
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(11, 23);
            this.chkPostre.Margin = new System.Windows.Forms.Padding(4);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(147, 20);
            this.chkPostre.TabIndex = 2;
            this.chkPostre.Text = "Agregar Postre + $1";
            this.chkPostre.UseVisualStyleBackColor = true;
            this.chkPostre.CheckedChanged += new System.EventHandler(this.chkPostre_CheckedChanged);
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Producto,
            this.Precio});
            this.lvCatalogo.FullRowSelect = true;
            this.lvCatalogo.HideSelection = false;
            listViewItem41.Tag = "";
            listViewItem42.IndentCount = 3;
            this.lvCatalogo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50});
            this.lvCatalogo.Location = new System.Drawing.Point(16, 85);
            this.lvCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.lvCatalogo.MultiSelect = false;
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(247, 245);
            this.lvCatalogo.TabIndex = 3;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.View = System.Windows.Forms.View.Details;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precio.Width = 59;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(16, 527);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 16);
            this.lbEstado.TabIndex = 5;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(351, 134);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(180, 22);
            this.txtProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(596, 134);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 22);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(8, 52);
            this.rbtnEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(187, 20);
            this.rbtnEntrega.TabIndex = 1;
            this.rbtnEntrega.TabStop = true;
            this.rbtnEntrega.Text = "Entrega a domicilio + $0.50";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnOpcion_CheckedChanged);
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(11, 52);
            this.chkServilletas.Margin = new System.Windows.Forms.Padding(4);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(205, 20);
            this.chkServilletas.TabIndex = 2;
            this.chkServilletas.Text = "Agregar Servilletas/Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(466, 405);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(113, 60);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.EnabledChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(598, 405);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 60);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(983, 405);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(272, 94);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(272, 143);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(537, 143);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(43, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cant. :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPostre);
            this.groupBox1.Controls.Add(this.chkServilletas);
            this.groupBox1.Location = new System.Drawing.Point(345, 287);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras del Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMostrador);
            this.groupBox2.Controls.Add(this.rbtnEntrega);
            this.groupBox2.Location = new System.Drawing.Point(345, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(365, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modalidad de atención";
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Location = new System.Drawing.Point(352, 23);
            this.lblNombreApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(344, 16);
            this.lblNombreApp.TabIndex = 5;
            this.lblNombreApp.Text = "Gestor de pedidos por catálogo - Cafertería Universitaria";
            // 
            // lblCatalogoProducto
            // 
            this.lblCatalogoProducto.AutoSize = true;
            this.lblCatalogoProducto.Location = new System.Drawing.Point(36, 54);
            this.lblCatalogoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatalogoProducto.Name = "lblCatalogoProducto";
            this.lblCatalogoProducto.Size = new System.Drawing.Size(144, 16);
            this.lblCatalogoProducto.TabIndex = 5;
            this.lblCatalogoProducto.Text = "Catálogo de productos";
            // 
            // lblDetallePedido
            // 
            this.lblDetallePedido.AutoSize = true;
            this.lblDetallePedido.Location = new System.Drawing.Point(752, 54);
            this.lblDetallePedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetallePedido.Name = "lblDetallePedido";
            this.lblDetallePedido.Size = new System.Drawing.Size(125, 16);
            this.lblDetallePedido.TabIndex = 5;
            this.lblDetallePedido.Text = "Detalles del pedido";
            this.lblDetallePedido.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(345, 405);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 60);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombreApp);
            this.Controls.Add(this.lblDetallePedido);
            this.Controls.Add(this.lblCatalogoProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lvPedido);
            this.Controls.Add(this.lvCatalogo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.RadioButton rbtnMostrador;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.CheckBox chkServilletas;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblCatalogoProducto;
        private System.Windows.Forms.Label lblDetallePedido;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvPedido;
    }
}

