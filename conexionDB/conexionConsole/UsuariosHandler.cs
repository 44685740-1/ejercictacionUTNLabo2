using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionConsole
{
    internal class UsuariosHandler : ComandoSQL, Imanejador<usuario>
    {
        public void Add(usuario entidad)
        {
            string query = "INSERT INTO usuarios (nombre, mail,password,EsAdministrador)" +
                           "VALUES (@nombre,@mail,@password,@EsAdministrador)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@mail", entidad.Mail);
                comando.Parameters.AddWithValue("@password", entidad.Password);
                comando.Parameters.AddWithValue("@EsAdministrador", entidad.EsAdministrador);
                EjecutarNonQuery(comando);
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM usuarios WHERE id = @id";

            using (SqlCommand comando = CrearComando(query)) 
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        public List<usuario> Leer()
        {
            string query = "SELECT * FROM usuarios";

            using (SqlCommand comando = CrearComando(query)) 
            {
                 List<usuario> listaUsuarios = new List<usuario>();
                 DataTable dataTable = EjecutarReader(comando);
                 listaUsuarios = usuario.ConvertirDataTableALista(dataTable);
                 return listaUsuarios;
            }
        }

        public void Modificar(usuario entidad)
        {
            string query = "UPDATE usuarios SET nombre = @nombre, mail = @mail, password = @password, EsAdministrador = @EsAdministrador  WHERE id = @id";

            using (SqlCommand comando = CrearComando(query)) 
            {
                comando.Parameters.AddWithValue("@id", entidad.Id);
                comando.Parameters.AddWithValue("@nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@mail", entidad.Mail);
                comando.Parameters.AddWithValue("@password", entidad.Password);
                comando.Parameters.AddWithValue("@EsAdministrador", entidad.EsAdministrador);
                EjecutarNonQuery(comando);
            }
        }
    }
}
