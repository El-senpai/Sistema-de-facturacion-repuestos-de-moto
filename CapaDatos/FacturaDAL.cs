using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class FacturaDAL
    {
        Conexion cn = new Conexion();

        public int CrearFactura(int clienteID, int empleadoID, decimal descuento)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_CrearFactura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@Descuento", descuento);
                cmd.Parameters.AddWithValue("@Observaciones", "");
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return (int)dr["FacturaID"];
                return 0;
            }
        }

        public void AgregarDetalle(int facturaID, int productoID, int cantidad, decimal precio, decimal descuento)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarDetalleFactura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", precio);
                cmd.Parameters.AddWithValue("@Descuento", descuento);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CerrarFactura(int facturaID)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_CerrarFactura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}