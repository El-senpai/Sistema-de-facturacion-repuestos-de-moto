namespace sistema_de_facturacion_repuestos_de_moto
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvFacturas = new DataGridView();
            dgvDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(118, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(512, 35);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(669, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(126, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(843, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(12, 60);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 62;
            dgvFacturas.RowTemplate.Height = 28;
            dgvFacturas.Size = new Size(783, 210);
            dgvFacturas.TabIndex = 4;
            dgvFacturas.SelectionChanged += dgvFacturas_SelectionChanged;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 376);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.RowTemplate.Height = 28;
            dgvDetalle.Size = new Size(783, 209);
            dgvDetalle.TabIndex = 5;
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1890, 1016);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvFacturas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmConsultar";
            Text = "Consultar factura ";
            Load += FrmConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}