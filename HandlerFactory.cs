using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Handlers
{
    internal class HandlerFactory
    {
        public static ProductoHandler  ObtenerHandlerProducto()
        {
            return new ProductoHandler();
        } 
        public static ProductoVendidoHandler  ObtenerHandlerProductoVendido()
        {
            return new ProductoVendidoHandler();
        }
        public static UsuarioHandler  ObtenerHandlerUsuario()
        {
            return new UsuarioHandler();
        }
        public static VentaHandler  ObtenerHandlerVenta()
        {
            return new VentaHandler();
        }

    }
}
