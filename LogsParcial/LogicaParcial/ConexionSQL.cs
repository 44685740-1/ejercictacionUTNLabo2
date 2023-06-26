using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public class ConexionSQL
    {
        protected SqlConnection _connection;
        protected static string _connectionString;

        static ConexionSQL()
        {
            _connectionString = "Server=.;Database=LogsPrueba;Trusted_Connection=True;";
        }

        public void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Cerrar()
        {
            _connection.Close();
        }
    }
}
