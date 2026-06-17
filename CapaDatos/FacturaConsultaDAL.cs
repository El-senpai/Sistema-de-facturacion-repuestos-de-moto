using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class FacturaConsultaDAL
    {
        Conexion cn = new Conexion();

        public DataTable BuscarFacturas(string texto)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarFacturas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Texto", string.IsNullOrEmpty(texto) ? (object)DBNull.Value : texto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerDetalle(int facturaID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_DetalleFacturaPorID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FacturaID", facturaID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}