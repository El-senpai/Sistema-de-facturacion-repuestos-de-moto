using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;                              
using System.Text.RegularExpressions;              
using System.Globalization;                        
using CapaEntidades;
using CapaNegocios;
using CapaDatos;
namespace sistema_de_facturacion_repuestos_de_moto
{
    public partial class FrmFacturacion : Form
    {
        ClienteNeg negCliente = new ClienteNeg();
        ProductoNeg negProducto = new ProductoNeg();
        List<DetalleFactura> listaDetalle = new List<DetalleFactura>();
        int facturaID = 0;
        int clienteIDSeleccionado = 0;

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            btnGuardarFactura.Enabled = false;

            if (cboCliente.Items.Count > 0)
            {
                cboCliente.SelectedIndex = 0;
                Cliente c = (Cliente)cboCliente.SelectedItem;
                clienteIDSeleccionado = c.ClienteID;
            }
        }

        private void CargarClientes()
        {
            var clientes = negCliente.Listar();
            cboCliente.DataSource = null;
            cboCliente.DataSource = new BindingList<Cliente>(clientes);
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "ClienteID";
        }

        private void CargarProductos()
        {
            cboProducto.DataSource = null;
            cboProducto.DataSource = new BindingList<Producto>(negProducto.Listar());
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "ProductoID";
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex >= 0 && cboCliente.SelectedItem != null)
            {
                Cliente c = (Cliente)cboCliente.SelectedItem;
                clienteIDSeleccionado = c.ClienteID;
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                Producto p = (Producto)cboProducto.SelectedItem;
                txtPrecio.Text = p.PrecioVenta.ToString("F2");
            }
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;
            foreach (var item in listaDetalle)
                subtotal += item.Subtotal;

            decimal iva = subtotal * 0.15m;
            decimal total = subtotal + iva;

            txtSubtotal.Text = "C$ " + subtotal.ToString("F2");
            txtIVA.Text = "C$ " + iva.ToString("F2");
            txtTotal.Text = "C$ " + total.ToString("F2");
        }

        private void ActualizarGrid()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle.ToList();

            dgvDetalle.Columns["ProductoID"].Visible = false;
            dgvDetalle.Columns["Codigo"].Visible = false;
            dgvDetalle.Columns["PrecioUnitario"].Visible = false;
            dgvDetalle.Columns["Descuento"].Visible = false;
            dgvDetalle.Columns["Subtotal"].Visible = false;

            dgvDetalle.Columns["Producto"].HeaderText = "Nombre";
            dgvDetalle.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDetalle.Columns["DescuentoStr"].HeaderText = "Descuento";
            dgvDetalle.Columns["SubtotalStr"].HeaderText = "Subtotal";
            dgvDetalle.Columns["IVAStr"].HeaderText = "IVA";
            dgvDetalle.Columns["TotalStr"].HeaderText = "Total";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem == null || txtCantidad.Text == "")
            {
                MessageBox.Show("Seleccione un producto e ingrese la cantidad.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto p = (Producto)cboProducto.SelectedItem;
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleFactura det = new DetalleFactura
            {
                ProductoID = p.ProductoID,
                Codigo = p.Codigo,
                Producto = p.Nombre,
                Cantidad = cantidad,
                PrecioUnitario = p.PrecioVenta,
                Descuento = 0,
                Subtotal = cantidad * p.PrecioVenta
            };

            listaDetalle.Add(det);
            ActualizarGrid();

            if (cboCliente.SelectedIndex >= 0 && cboCliente.SelectedItem != null)
            {
                Cliente c = (Cliente)cboCliente.SelectedItem;
                lblClienteSeleccionado.Text = "Cliente: " + c.Nombre + " " + c.Apellido;
            }
            lblFechaFactura.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");

            CalcularTotales();
            btnGuardarFactura.Enabled = true;
            txtCantidad.Text = "";
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (listaDetalle.Count == 0)
            {
                MessageBox.Show("Agregue productos primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = 0;
            foreach (var item in listaDetalle)
                subtotal += item.Subtotal;

            decimal descuento = subtotal * 0.10m;

            foreach (var item in listaDetalle)
            {
                item.Descuento = item.Subtotal * 0.10m;
                item.Subtotal = item.Subtotal - item.Descuento;
            }

            ActualizarGrid();

            decimal subtotalConDesc = subtotal - descuento;
            decimal iva = subtotalConDesc * 0.15m;
            decimal total = subtotalConDesc + iva;

            txtSubtotal.Text = "C$ " + subtotalConDesc.ToString("F2");
            txtIVA.Text = "C$ " + iva.ToString("F2");
            txtTotal.Text = "C$ " + total.ToString("F2");

            MessageBox.Show("Descuento de 10% aplicado: C$ " + descuento.ToString("F2"), "Descuento",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            listaDetalle.Clear();
            dgvDetalle.DataSource = null;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";
            facturaID = 0;
            clienteIDSeleccionado = 0;
            lblClienteSeleccionado.Text = "Cliente:";
            lblFechaFactura.Text = "Fecha:";
            btnGuardarFactura.Enabled = false;
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (listaDetalle.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FacturaDAL facDAL = new FacturaDAL();
                int clienteID = clienteIDSeleccionado > 0
                    ? clienteIDSeleccionado
                    : ((Cliente)cboCliente.Items[0]).ClienteID;
                int empleadoID = 1;

                facturaID = facDAL.CrearFactura(clienteID, empleadoID, 0);

                foreach (var det in listaDetalle)
                    facDAL.AgregarDetalle(facturaID, det.ProductoID, det.Cantidad, det.PrecioUnitario, det.Descuento);

                facDAL.CerrarFactura(facturaID);

                MessageBox.Show("Factura guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNuevaFactura_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && cboProducto.SelectedItem != null)
            {
                Producto p = (Producto)cboProducto.SelectedItem;
                txtPrecio.Text = p.PrecioVenta.ToString("F2");
            }
        }


    }
}