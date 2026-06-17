using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class ClienteNeg
    {
   
        private readonly ClienteDAL dal;

        public ClienteNeg()
        {
            dal = new ClienteDAL();
        }

     
        public ClienteNeg(ClienteDAL dal)
        {
            this.dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public List<Cliente> Listar()
        {
            try
            {
                return dal.Listar();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al listar clientes en CapaNegocios.ClienteNeg.", ex);
            }
        }

        public void Insertar(Cliente c)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));
            try
            {
                dal.Insertar(c);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al insertar cliente en CapaNegocios.ClienteNeg.", ex);
            }
        }

        public void Actualizar(Cliente c)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));
            try
            {
                dal.Actualizar(c);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al actualizar cliente en CapaNegocios.ClienteNeg.", ex);
            }
        }

        public void Eliminar(int clienteID)
        {
            if (clienteID <= 0) throw new ArgumentOutOfRangeException(nameof(clienteID));
            try
            {
                dal.Eliminar(clienteID);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al eliminar cliente en CapaNegocios.ClienteNeg.", ex);
            }
        }
    }
}
