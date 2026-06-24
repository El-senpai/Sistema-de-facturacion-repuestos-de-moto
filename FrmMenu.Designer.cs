namespace sistema_de_facturacion_repuestos_de_moto
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            label1 = new Label();
            label2 = new Label();
            btnProductos = new Button();
            btnClientes = new Button();
            btnFacturacion = new Button();
            btnConsultar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(539, 11);
            label1.Name = "label1";
            label1.Size = new Size(583, 46);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(690, 89);
            label2.Name = "label2";
            label2.Size = new Size(324, 29);
            label2.TabIndex = 1;
            label2.Text = "Venta de Repuestos de Moto";
            label2.Click += label2_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.LightCyan;
            btnProductos.FlatStyle = FlatStyle.Popup;
            btnProductos.Location = new Point(33, 139);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(149, 80);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(33, 226);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(149, 76);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Location = new Point(33, 321);
            btnFacturacion.Margin = new Padding(3, 4, 3, 4);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(149, 72);
            btnFacturacion.TabIndex = 4;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(33, 418);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(149, 65);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = " Consultar Facturas";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(33, 501);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 70);
            btnSalir.TabIndex = 6;
            btnSalir.Text = " Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1767, 841);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(btnFacturacion);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Facturación - Repuestos de Moto";
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}