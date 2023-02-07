using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Handlers
{
    internal class VentaHandler
    {
        List<Venta> ventas (int IdUsuario)
        {
            List<Venta> ventas = new List<Venta>();
            string cadenaConexion = "Data Source=DESKTOP-GPK2NFU\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Venta WHERE IdUsuario = @IdUsuario", conn);
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    VentaHandler ventaTemp = new Venta();
                    while (reader.Read())
                    {
                        ventaTemp.Id = reader.getint64(0);
                        ventaTemp.Comentario = reader.getintstring(1);
                        ventaTemp.IdUsuario = eader.getint64(2);

                        ventas.add(ventaTemp);
                    }
                    return ventas;
            }
}
