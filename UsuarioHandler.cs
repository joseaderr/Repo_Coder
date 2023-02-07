using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Handlers
{
    internal class UsuarioHandler
    {
        Usuario TraerUsuario(String Nombre)
        {
            Usuario u = new Usuario();
            string cadenaConexion = "Data Source=DESKTOP-GPK2NFU\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT FROM Usuario WHERE Nombre = @Nombre", conn);
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {


                    u.Id = reader.GetInt64(0);
                    u.Nombre = reader.GetString(1);
                    u.Apellido = reader.GetString(2);
                    u.NombreUsuario = reader.GetString(4);
                    u.Contraseña = reader.GetString(5);
                    u.Mail = reader.GetString(6);



                }
                return u;
            }

            public Usuario inicioDeSesion(string nombreU, string contraseña)
            {

                string cadenaConexion = "Data Source=DESKTOP-GPK2NFU\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand("SELECT FROM Usuario WHERE NombreUsuario = @nombreU AND @Contraseña = @contraseña", conn);
                    conn.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Usuario u = new Usuario();
                        reader.Read();

                        u.Id = reader.GetInt64(0);
                        u.Nombre = reader.GetString(1);
                        u.Apellido = reader.GetString(2);
                        u.NombreUsuario = reader.GetString(4);
                        u.Contraseña = reader.GetString(5);
                        u.Mail = reader.GetString(6);

                        return u;

                    }

                }

            }



        }

    }
}
