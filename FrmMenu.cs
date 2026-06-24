using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion_repuestos_de_moto
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.FlatAppearance.BorderSize = 2;
            btnProductos.FlatAppearance.BorderColor = Color.Red;
            btnProductos.BackColor = Color.FromArgb(45, 45, 45);
            btnProductos.ForeColor = Color.White;

            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.FlatAppearance.BorderSize = 2;
            btnClientes.FlatAppearance.BorderColor = Color.Red;
            btnClientes.BackColor = Color.FromArgb(45, 45, 45);
            btnClientes.ForeColor = Color.White;

            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.FlatAppearance.BorderSize = 2;
            btnFacturacion.FlatAppearance.BorderColor = Color.Red;
            btnFacturacion.BackColor = Color.FromArgb(45, 45, 45);
            btnFacturacion.ForeColor = Color.White;

            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatAppearance.BorderColor = Color.Red;
            btnConsultar.BackColor = Color.FromArgb(45, 45, 45);
            btnConsultar.ForeColor = Color.White;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.BackColor = Color.FromArgb(45, 45, 45);
            btnSalir.ForeColor = Color.White;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar frm = new FrmConsultar();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
