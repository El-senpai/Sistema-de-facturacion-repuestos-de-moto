using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class ProductoNeg
    {
        // Verifica que la clase ProductoDAL exista en el proyecto y esté en el namespace CapaDatos.
        ProductoDAL dal = new ProductoDAL();

        public List<Producto> Listar()
        {
            return dal.Listar();
        }

        public List<Producto> Buscar(string termino)
        {
            return dal.Buscar(termino);
        }

        public void Insertar(Producto p)
        {
            dal.Insertar(p);
        }

        public void Actualizar(Producto p)
        {
            dal.Actualizar(p);
        }

        public void Eliminar(int productoID)
        {
            dal.Eliminar(productoID);
        }
    }
}
