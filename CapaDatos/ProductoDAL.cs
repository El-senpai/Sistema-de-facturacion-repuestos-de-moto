using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class ProductoDAL
    {
        Conexion cn = new Conexion();

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        ProductoID = (int)dr["ProductoID"],
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Categoria = dr["Categoria"].ToString(),
                        PrecioVenta = (decimal)dr["PrecioVenta"],
                        StockActual = (int)dr["StockActual"]
                    });
                }
            }
            return lista;
        }

        public List<Producto> Buscar(string termino)
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Termino", termino);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        ProductoID = (int)dr["ProductoID"],
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Categoria = dr["Categoria"].ToString(),
                        PrecioVenta = (decimal)dr["PrecioVenta"],
                        StockActual = (int)dr["StockActual"]
                    });
                }
            }
            return lista;
        }

        public void Insertar(Producto p)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@CategoriaID", p.CategoriaID);
                cmd.Parameters.AddWithValue("@PrecioCompra", p.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", p.PrecioVenta);
                cmd.Parameters.AddWithValue("@StockActual", p.StockActual);
                cmd.Parameters.AddWithValue("@StockMinimo", p.StockMinimo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto p)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", p.ProductoID);
                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@CategoriaID", p.CategoriaID);
                cmd.Parameters.AddWithValue("@PrecioCompra", p.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", p.PrecioVenta);
                cmd.Parameters.AddWithValue("@StockMinimo", p.StockMinimo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int productoID)
        {
            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}