using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    
    public class DetalleFactura
        {
            public int ProductoID { get; set; }
            public string Codigo { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Descuento { get; set; }
            public decimal Subtotal { get; set; }
            public string DescuentoStr => "C$ " + Descuento.ToString("F2");
            public string SubtotalStr => "C$ " + Subtotal.ToString("F2");
            public string IVAStr => "C$ " + (Subtotal * 0.15m).ToString("F2");
            public string TotalStr => "C$ " + ((Subtotal * 1.15m)).ToString("F2");
        }
    }
