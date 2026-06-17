using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ClienteDAL
    {
        Conexion cn = new Conexion();

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        ClienteID = (int)dr["ClienteID"],
                        Cedula = dr["Cedula"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Direccion = dr["Direccion"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insertar(Cliente c)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", c.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Correo", c.Correo);
                cmd.Parameters.AddWithValue("@Direccion", c.Direccion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Cliente c)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", c.ClienteID);
                cmd.Parameters.AddWithValue("@Cedula", c.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Correo", c.Correo);
                cmd.Parameters.AddWithValue("@Direccion", c.Direccion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int clienteID)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}