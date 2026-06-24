using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace sistema_de_facturacion_repuestos_de_moto
{
    public partial class FrmClientes : Form
    {
        ClienteNeg neg = new ClienteNeg();
        int id = 0;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = neg.Listar();
        }

        private void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
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
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El teléfono debe tener exactamente 8 dígitos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente c = new Cliente
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text
            };

            try
            {
                neg.Insertar(c);
                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarClientes();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El teléfono debe tener exactamente 8 dígitos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cliente c = new Cliente
            {
                ClienteID = id,
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text
            };

            neg.Actualizar(c);
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este cliente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                neg.Eliminar(id);
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarClientes();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvClientes.DataSource = neg.Listar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                id = int.Parse(row.Cells["ClienteID"].Value.ToString());
                txtCedula.Text = row.Cells["Cedula"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
} 