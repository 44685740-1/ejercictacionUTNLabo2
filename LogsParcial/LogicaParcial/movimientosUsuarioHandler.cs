using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public class movimientosUsuarioHandler : ComandoSQL
    {
        public void add(string usuario, string accion, string nombreFrm)
        {
            string query = "INSERT INTO movimientos (usuario,accion,nombreFrm)" +
                            "VALUES (@usuario,@accion,@nombreFrm)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@accion", accion);
                comando.Parameters.AddWithValue("@nombreFrm", nombreFrm);
                EjecutarNonQuery(comando);
            }
        }
    }
}
