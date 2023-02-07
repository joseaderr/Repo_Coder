using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Models
{
    internal class Venta
    {


        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public string Comentarios { get; set; }
    }
    public Venta(long id, long idusuario, string comentarios)
    {
        this.Id = id;
        this.IdUsuario = idusuario;
        this.Comentarios = comentarios;
      
    }

    public Venta() { }

}
