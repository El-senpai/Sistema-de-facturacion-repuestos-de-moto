namespace sistema_de_facturacion_repuestos_de_moto
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            groupBox1 = new GroupBox();
            cboCategoria = new ComboBox();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrecioVenta = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label7 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(cboCategoria);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecioVenta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(494, 464);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(169, 351);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(295, 37);
            cboCategoria.TabIndex = 11;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(6, 354);
            label6.Name = "label6";
            label6.Size = new Size(134, 29);
            label6.TabIndex = 10;
            label6.Text = "Categoría:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(130, 280);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(111, 35);
            txtStock.TabIndex = 9;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(6, 280);
            label5.Name = "label5";
            label5.Size = new Size(85, 29);
            label5.TabIndex = 8;
            label5.Text = "Stock:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(201, 200);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(143, 35);
            txtPrecioVenta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(-6, 200);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 4;
            label3.Text = "Precio Venta:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonHighlight;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = SystemColors.InactiveCaptionText;
            txtNombre.Location = new Point(148, 131);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 28);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(-6, 131);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 2;
            label2.Text = " Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(130, 65);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(214, 35);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 71);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(720, 1);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(334, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(181, 104);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(167, 39);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(124, 52);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(7, 99);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 49);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(7, 42);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 49);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(13, 482);
            label7.Name = "label7";
            label7.Size = new Size(100, 29);
            label7.TabIndex = 2;
            label7.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(130, 488);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(364, 31);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(513, 482);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(155, 50);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(13, 558);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.RowTemplate.Height = 28;
            dgvProductos.Size = new Size(1104, 355);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1301, 926);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos";
            Load += FrmProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}