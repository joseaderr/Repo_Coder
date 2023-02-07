using EsqueletoPrimerEntregaJV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EsqueletoPrimerEntregaJV.DataBaseTool;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoPrimerEntregaJV.Handlers
{
    internal class ProductoHandler
    {
        /    public List<Producto> TraerProducto(int IdUsuario)
        {
            List<Producto> productos = new List<Producto>();
            string cadenaConexion = "Data Source=DESKTOP-GPK2NFU\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE IdUsuario = @IdUsuario", conn);
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto ProdTemp = new Producto();

                        ProdTemp.Id = reader.GetInt64(0);
                        ProdTemp.Descripciones = reader.GetString(1);
                        ProdTemp.Costo = reader.GetDecimal(2);
                        ProdTemp.PrecioVenta = reader.GetInt64(4);
                        ProdTemp.IdUsuario = reader.GetInt64(5);

                        productos.Add(ProdTemp);


                    }
                }
                return productos;
            }

        }
}

