using System;
using System.Windows.Forms;
using CapaDatos;

namespace sistema_de_facturacion_repuestos_de_moto
{
    public partial class FrmConsultar : Form
    {
        FacturaConsultaDAL facDAL = new FacturaConsultaDAL();

        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CargarFacturas("");
        }

        private void CargarFacturas(string texto)
        {
            dgvFacturas.DataSource = facDAL.BuscarFacturas(texto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarFacturas(txtBuscar.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CargarFacturas("");
            dgvDetalle.DataSource = null;
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null) return;
            int facturaID = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["FacturaID"].Value);
            dgvDetalle.DataSource = facDAL.ObtenerDetalle(facturaID);
        }
    }
}