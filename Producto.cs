using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Models
{
    internal class Producto
    {
        //PROPERTIES AUTOMATICAS
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public int Stock { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Descripcion { get; set; }
        
         public Producto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
            {
                Id = id;
                Descripciones = descripciones;
                Costo = costo;
                PrecioVenta = precioVenta;
                Stock = stock;
                IdUsuario = idUsuario;
            }
        public Producto() { }
      
       //OVERRIDE DEL METODO ToString
        public override string ToString()
        {
            return $"Id Producto: {Id} " + "\n"
            + $"Id Usuario:  { IdUsuario}" + "\n"
            + $"Stock: {Stock}" + "\n"
            + $"Costo: {Costo}" + "\n"
            + $"Precio de Venta: {PrecioVenta}" + "\n"
            + $"Descripcion: {Descripcion}" + "\n"
            + "------------------------------------";
        }
    }
}

