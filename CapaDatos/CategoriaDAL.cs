using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        Conexion cn = new Conexion();

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection con = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT CategoriaID, Nombre FROM Categorias", con);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = (int)dr["CategoriaID"],
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return lista;
        }
    }
}