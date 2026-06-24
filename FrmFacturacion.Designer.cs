namespace sistema_de_facturacion_repuestos_de_moto
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            groupBox1 = new GroupBox();
            txtFecha = new TextBox();
            label2 = new Label();
            cboCliente = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            cboProducto = new ComboBox();
            label3 = new Label();
            dgvDetalle = new DataGridView();
            groupBox3 = new GroupBox();
            txtTotal = new TextBox();
            label8 = new Label();
            txtIVA = new TextBox();
            label7 = new Label();
            txtSubtotal = new TextBox();
            label6 = new Label();
            btnNuevaFactura = new Button();
            btnGuardarFactura = new Button();
            btnCancelar = new Button();
            btnDescuento = new Button();
            lblClienteSeleccionado = new Label();
            lblFechaFactura = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(0, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Factura";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(443, 47);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(154, 35);
            txtFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(345, 50);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(115, 47);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(169, 37);
            cboCliente.TabIndex = 1;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboProducto);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(0, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(551, 237);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(345, 181);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 47);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 187);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(147, 35);
            txtPrecio.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(6, 187);
            label5.Name = "label5";
            label5.Size = new Size(96, 29);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(137, 127);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(147, 35);
            txtCantidad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 2;
            label4.Text = "Cantidad:";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(137, 64);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(339, 37);
            cboProducto.TabIndex = 1;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 0;
            label3.Text = "Producto:";
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(11, 402);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.RowTemplate.Height = 28;
            dgvDetalle.Size = new Size(1028, 345);
            dgvDetalle.TabIndex = 7;
            dgvDetalle.CellClick += dgvDetalle_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtIVA);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtSubtotal);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(983, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 203);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(92, 150);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 35);
            txtTotal.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 150);
            label8.Name = "label8";
            label8.Size = new Size(80, 29);
            label8.TabIndex = 4;
            label8.Text = "Total:";
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(147, 100);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 35);
            txtIVA.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 100);
            label7.Name = "label7";
            label7.Size = new Size(135, 29);
            label7.TabIndex = 2;
            label7.Text = "IVA (15%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(121, 54);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(147, 35);
            txtSubtotal.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 54);
            label6.Name = "label6";
            label6.Size = new Size(116, 29);
            label6.TabIndex = 0;
            label6.Text = "Subtotal:";
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Location = new Point(1057, 481);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(201, 42);
            btnNuevaFactura.TabIndex = 3;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            btnNuevaFactura.Click += btnNuevaFactura_Click;
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.Location = new Point(1057, 556);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(217, 42);
            btnGuardarFactura.TabIndex = 4;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = true;
            btnGuardarFactura.Click += btnGuardarFactura_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1057, 623);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDescuento
            // 
            btnDescuento.Location = new Point(1057, 402);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(217, 35);
            btnDescuento.TabIndex = 8;
            btnDescuento.Text = "Descuento 10%";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.AutoSize = true;
            lblClienteSeleccionado.Location = new Point(6, 336);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(103, 29);
            lblClienteSeleccionado.TabIndex = 9;
            lblClienteSeleccionado.Text = "Cliente:";
            // 
            // lblFechaFactura
            // 
            lblFechaFactura.AutoSize = true;
            lblFechaFactura.Location = new Point(12, 370);
            lblFechaFactura.Name = "lblFechaFactura";
            lblFechaFactura.Size = new Size(92, 29);
            lblFechaFactura.TabIndex = 10;
            lblFechaFactura.Text = "Fecha:";
            // 
            // FrmFacturacion
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1286, 823);
            Controls.Add(lblFechaFactura);
            Controls.Add(lblClienteSeleccionado);
            Controls.Add(btnDescuento);
            Controls.Add(dgvDetalle);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarFactura);
            Controls.Add(btnNuevaFactura);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmFacturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturación";
            Load += FrmFacturacion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Label lblClienteSeleccionado;
        private System.Windows.Forms.Label lblFechaFactura;
    }
}