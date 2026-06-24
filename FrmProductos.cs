using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace sistema_de_facturacion_repuestos_de_moto
{
    public partial class FrmProductos : Form
    {
        ProductoNeg neg = new ProductoNeg();
        int id = 0;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = neg.Listar();
            dgvProductos.Columns["CategoriaID"].Visible = false;
            dgvProductos.Columns["PrecioCompra"].Visible = false;
            dgvProductos.Columns["StockMinimo"].Visible = false;
        }

        private void CargarCategorias()
        {
            CapaDatos.CategoriaDAL catDal = new CapaDatos.CategoriaDAL();
            cboCategoria.DataSource = catDal.Listar();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "CategoriaID";
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            cboCategoria.SelectedIndex = 0;
            id = 0;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Código y Nombre son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto p = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                CategoriaID = (int)cboCategoria.SelectedValue,
                PrecioCompra = 0,
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                StockActual = int.Parse(txtStock.Text),
                StockMinimo = 5
            };

            neg.Insertar(p);
            MessageBox.Show("Producto guardado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto p = new Producto
            {
                ProductoID = id,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                CategoriaID = (int)cboCategoria.SelectedValue,
                PrecioCompra = 0,
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                StockMinimo = 5
            };

            neg.Actualizar(p);
            MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este producto?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                neg.Eliminar(id);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarProductos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = neg.Buscar(txtBuscar.Text);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                id = int.Parse(row.Cells["ProductoID"].Value.ToString());
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = row.Cells["StockActual"].Value.ToString();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}