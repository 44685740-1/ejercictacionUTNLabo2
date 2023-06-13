using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace conexionConsole
{
    public class ComandoSQL : ConexionSQL
    {
        public SqlCommand CrearComando(string query) 
        {
            Abrir();
            SqlCommand comando = new SqlCommand(query, _connection);
            return comando;
        }

        public DataTable EjecutarReader(SqlCommand comando) 
        {
            var reader = comando.ExecuteReader();   
            var dataTable = new DataTable();    
            dataTable.Load(reader);
            reader.Close();
            return dataTable;   
        }

        public void EjecutarNonQuery(SqlCommand comando) 
        {
            comando.ExecuteNonQuery();
        }
    }
}
