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
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem(new string[] {
            "Empanada de queso",
            "1.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sánduche de pollo",
            "2.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bolón de verde mixto",
            "2.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem(new string[] {
            "Humita Tradicional",
            "1.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem(new string[] {
            "tostada con queso",
            "1.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem(new string[] {
            "Café pasado",
            "0.85"}, -1);
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem(new string[] {
            "Chocolate Caliente",
            "1.35"}, -1);
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jugo natural (naranja/mora)",
            "1.50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem(new string[] {
            "Batido de fruta",
            "2.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem(new string[] {
            "Botella de agua",
            "0.50"}, -1);
            System.Windows.Forms.ListView lvPedido;
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.rbtnMostador = new System.Windows.Forms.RadioButton();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
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
            Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvPedido = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 100;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(263, 69);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(270, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // rbtnMostador
            // 
            this.rbtnMostador.AutoSize = true;
            this.rbtnMostador.Location = new System.Drawing.Point(6, 19);
            this.rbtnMostador.Name = "rbtnMostador";
            this.rbtnMostador.Size = new System.Drawing.Size(117, 17);
            this.rbtnMostador.TabIndex = 1;
            this.rbtnMostador.TabStop = true;
            this.rbtnMostador.Text = "Retiro en mostrador";
            this.rbtnMostador.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(8, 19);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(120, 17);
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
            this.lvCatalogo.HideSelection = false;
            listViewItem31.Tag = "";
            listViewItem32.IndentCount = 3;
            this.lvCatalogo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40});
            this.lvCatalogo.Location = new System.Drawing.Point(12, 69);
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(186, 200);
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(259, 329);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 428);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "label1";
            // 
            // lvPedido
            // 
            lvPedido.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvPedido.HideSelection = false;
            lvPedido.LabelEdit = true;
            lvPedido.Location = new System.Drawing.Point(567, 65);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new System.Drawing.Size(205, 241);
            lvPedido.TabIndex = 3;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.View = System.Windows.Forms.View.Details;
            lvPedido.VirtualMode = true;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(263, 109);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(136, 20);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(447, 109);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 20);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.EnabledChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(6, 42);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(153, 17);
            this.rbtnEntrega.TabIndex = 1;
            this.rbtnEntrega.TabStop = true;
            this.rbtnEntrega.Text = "Entrega a domicilio + $0.50";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(8, 42);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(163, 17);
            this.chkServilletas.TabIndex = 2;
            this.chkServilletas.Text = "Agregar Servilletas/Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(448, 329);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(85, 49);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Limpiar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.EnabledChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.btnQuitar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(357, 329);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 49);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Quitar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(737, 329);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(204, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(204, 116);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(403, 116);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(38, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cant. :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPostre);
            this.groupBox1.Controls.Add(this.chkServilletas);
            this.groupBox1.Location = new System.Drawing.Point(259, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras del Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMostador);
            this.groupBox2.Controls.Add(this.rbtnEntrega);
            this.groupBox2.Location = new System.Drawing.Point(259, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modalidad de atención";
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Location = new System.Drawing.Point(264, 19);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(272, 13);
            this.lblNombreApp.TabIndex = 5;
            this.lblNombreApp.Text = "Gestor de pedidos por catálogo - Cafertería Universitaria";
            // 
            // lblCatalogoProducto
            // 
            this.lblCatalogoProducto.AutoSize = true;
            this.lblCatalogoProducto.Location = new System.Drawing.Point(27, 44);
            this.lblCatalogoProducto.Name = "lblCatalogoProducto";
            this.lblCatalogoProducto.Size = new System.Drawing.Size(114, 13);
            this.lblCatalogoProducto.TabIndex = 5;
            this.lblCatalogoProducto.Text = "Catálogo de productos";
            // 
            // lblDetallePedido
            // 
            this.lblDetallePedido.AutoSize = true;
            this.lblDetallePedido.Location = new System.Drawing.Point(564, 44);
            this.lblDetallePedido.Name = "lblDetallePedido";
            this.lblDetallePedido.Size = new System.Drawing.Size(97, 13);
            this.lblDetallePedido.TabIndex = 5;
            this.lblDetallePedido.Text = "Detalles del pedido";
            this.lblDetallePedido.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombreApp);
            this.Controls.Add(this.lblDetallePedido);
            this.Controls.Add(this.lblCatalogoProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(lvPedido);
            this.Controls.Add(this.lvCatalogo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.RadioButton rbtnMostador;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstado;
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
    }
}

