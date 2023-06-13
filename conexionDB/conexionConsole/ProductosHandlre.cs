using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionConsole
{
    public class ProductosHandlre : ComandoSQL, Imanejador<producto>
    {
        public void Add(producto entidad)
        {
            string query = "INSERT INTO productos (nombre,precio,cantidad)" +
                            "VALUES (@nombre,@precio,@cantidad)";

            using(SqlCommand comando = CrearComando(query)) 
            { 
                comando.Parameters.AddWithValue("@nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@precio", entidad.Precio);
                comando.Parameters.AddWithValue("@cantidad", entidad.Cantidad);
                EjecutarNonQuery(comando);  
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM productos WHERE id = @id";

            using (SqlCommand comando = CrearComando(query)) 
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        public List<producto> Leer()
        {
            string query = "SELECT * FROM productos";

            using (SqlCommand comando = CrearComando(query)) 
            {
                List<producto> listaProductos = new List<producto>();
                DataTable dataTable = EjecutarReader(comando);
                listaProductos = producto.ConvertirDataTableALista(dataTable);  
                return listaProductos;  
            }
        }

        public void Modificar(producto entidad)
        {
            string query = "UPDATE productos SET nombre = @nombre, precio = @precio, cantidad = @cantidad WHERE id = @id";

            using (SqlCommand comando = CrearComando(query)) 
            {
                comando.Parameters.AddWithValue("@id", entidad.Id);
                comando.Parameters.AddWithValue("@nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@precio", entidad.Precio);
                comando.Parameters.AddWithValue("@cantidad", entidad.Cantidad);
                EjecutarNonQuery(comando);
            }
        }
    }
}
