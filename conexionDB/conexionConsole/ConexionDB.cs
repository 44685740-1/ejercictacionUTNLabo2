using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace conexionConsole
{
    public static class ConexionDB
    {
        //CONEXION Y ABM PERO HECHO ESTATICO
        private static SqlConnection _connection;       
        private static SqlCommand _command; 
        private static string _connectionString;
        
        static ConexionDB() 
        {
            _connectionString = "Server=.;Database=segundo_parcial_labo2;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
            //_command = _connection.CreateCommand();
            //_command.Parameters.Clear();
            _command = new SqlCommand();    
            _command.Connection = _connection;
            _command.CommandType = System.Data.CommandType.Text;    
        }

        public static List<usuario> leer(List<usuario> listausuarios) 
        {
            
            try
            {
                _connection.Open();
                _command.CommandText = "SELECT * FROM usuarios";

                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read()) 
                    {
                        int id = Convert.ToInt32(dataReader["id"]);
                        string nombre = dataReader["nombre"].ToString();
                        string mail = dataReader["mail"].ToString();
                        string password = dataReader["password"].ToString();
                        int EsAdministrador = Convert.ToInt32(dataReader["EsAdministrador"]);
                        listausuarios.Add(new usuario(id, nombre, mail, password, EsAdministrador));
                    }
                }
            }
            catch (Exception)
            {
                throw;

            } finally 
            {
                _connection.Close();    
            }
            return listausuarios;   
        }


        public static List<producto> leer(List<producto> listaProductos)
        {
            
            try
            {
                _connection.Open();
                _command.CommandText = "SELECT * FROM productos";

                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["id"]);     
                        string nombre = dataReader["nombre"].ToString();
                        int precio = Convert.ToInt32(dataReader["precio"]);
                        int cantidad = Convert.ToInt32(dataReader["cantidad"]);
                        listaProductos.Add(new producto(id,nombre,precio, cantidad));
                    }
                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                _connection.Close();
            }
            return listaProductos;  
        }

        
        public static int add(usuario usuario) 
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"INSERT INTO usuarios(nombre, mail, password,EsAdministrador) VALUES ('{usuario.Nombre}', '{usuario.Mail}', '{usuario.Password}', {usuario.EsAdministrador}); ";

                return _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                _connection.Close();
            }
        }


        public static int delete(usuario usuario)
        {
            _command.Parameters.Clear();
            try
            {
                _connection.Open();
                _command.CommandText = $"DELETE FROM usuarios WHERE id = @id";
                _command.Parameters.AddWithValue("@id", usuario.Id);
                   
                return _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }


        public static int modificar(usuario usuario) 
        {
            _command.Parameters.Clear();
            try
            {
                _connection.Open();
                
                _command.CommandText = $"UPDATE usuarios SET nombre = @nombre, mail = @mail, password = @password WHERE id = @id";
                _command.Parameters.AddWithValue("@id", usuario.Id);
                _command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                _command.Parameters.AddWithValue("@mail", usuario.Mail);
                _command.Parameters.AddWithValue("@password", usuario.Password);
                
                return _command.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
