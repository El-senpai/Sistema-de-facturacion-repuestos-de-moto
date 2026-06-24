namespace sistema_de_facturacion_repuestos_de_moto
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            groupBox1 = new GroupBox();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label7 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvClientes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(3, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(626, 489);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos del Cliente";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(170, 388);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(448, 35);
            txtDireccion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(10, 388);
            label6.Name = "label6";
            label6.Size = new Size(138, 29);
            label6.TabIndex = 10;
            label6.Text = "Dirección: ";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(143, 318);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(382, 35);
            txtCorreo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(10, 318);
            label5.Name = "label5";
            label5.Size = new Size(108, 29);
            label5.TabIndex = 8;
            label5.Text = "Correo: ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(152, 256);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 35);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(7, 256);
            label4.Name = "label4";
            label4.Size = new Size(125, 29);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 189);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(218, 35);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 189);
            label3.Name = "label3";
            label3.Size = new Size(117, 29);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 121);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 35);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(10, 121);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(130, 55);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(363, 35);
            txtCedula.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(7, 55);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 0;
            label1.Text = " Cédula: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(684, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(328, 211);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(179, 138);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 48);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(7, 130);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 55);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(179, 55);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 56);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = SystemColors.ActiveCaptionText;
            btnNuevo.Location = new Point(7, 55);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(146, 55);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = " Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 522);
            label7.Name = "label7";
            label7.Size = new Size(100, 29);
            label7.TabIndex = 2;
            label7.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(131, 528);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(330, 31);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(489, 528);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 42);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(3, 602);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 28;
            dgvClientes.Size = new Size(1299, 328);
            dgvClientes.TabIndex = 5;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1331, 972);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            Text = "Gestión de Clientes";
            Load += FrmClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}