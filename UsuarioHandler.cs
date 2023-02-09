using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntregaJosefinaAlvarez
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
                    u.Email = reader.GetString(4);
                    u.UserName = reader.GetString(5);
                    u.Password = reader.GetString(6);


                }
                return u;
            }
        }
             Usuario inicioDeSesion(String nombreU, String contraseña)
            {

                string cadenaConexion = "Data Source=DESKTOP-GPK2NFU\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand comando = new SqlCommand("SELECT FROM Usuario WHERE NombreUsuario = @nombreU AND @Contraseña = @contraseña", conn);
                    conn.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                Usuario u = new Usuario();
                if (reader.HasRows)
                    {
                        
                        reader.Read();

                        u.Id = reader.GetInt64(0);
                        u.Nombre = reader.GetString(1);
                        u.Apellido = reader.GetString(2);
                        u.Email = reader.GetString(4);
                        u.UserName = reader.GetString(5);
                        u.Password = reader.GetString(6);

                   
                }
                return u;
            }

                
            }



        

    }
}
