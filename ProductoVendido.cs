using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Models
{
    internal class ProductoVendido
    {
        public long Id { get; set; }
        public int Stock { get; set; }
        public long IdProducto { get; set; }
        public long IdVenta { get; set; }
   
    }

    public ProductoVendido(long id, string stock, long idproducto , long idventa )
    {
        Id = id;
        Stock = stock;
        IdProducto = idproducto
        IdVenta = idventa;
    public ProductoVendido() { }
}
}
