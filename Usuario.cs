using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Models
{
    internal class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Usuario(long id, string nombre, string apellido, string mail, string nombreUsuario, string contraseña)
        {
            this.Id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public Usuario() { }

    }
}
