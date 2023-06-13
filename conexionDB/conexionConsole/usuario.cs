using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionConsole
{
    public class usuario
    {
        private int _id;
        private string _nombre;
        private string _mail;
        private string _password;
        private int _EsAdministrador;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Password { get => _password; set => _password = value; }
        public int EsAdministrador { get => _EsAdministrador; set => _EsAdministrador = value; }

        public usuario(int id, string nombre, string mail, string password, int esAdministrador)
        {
            _id = id;
            _nombre = nombre;
            _mail = mail;
            _password = password;
            _EsAdministrador = esAdministrador;
        }

        public usuario(string nombre, string mail, string password, int esAdministrador)
        {
            _nombre = nombre;
            _mail = mail;
            _password = password;
            _EsAdministrador = esAdministrador;
        }

        public usuario() 
        {
            
        }

        public override string ToString()
        {
            return $"{this.Id} {this.Nombre} {this.Mail} {this.Password} {this.EsAdministrador}";
        }

        
        public static List<usuario> ConvertirDataTableALista(DataTable dataTable) 
        {
            List<usuario> listaUsuarios = new List<usuario>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                usuario usuario = new usuario();
                usuario.Id = Convert.ToInt32(dataTable.Rows[i]["id"]);
                usuario.Nombre = dataTable.Rows[i]["nombre"].ToString();
                usuario.Mail = dataTable.Rows[i]["mail"].ToString();
                usuario.EsAdministrador = Convert.ToInt32(dataTable.Rows[i]["EsAdministrador"]);
                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;  
        }
        
    }
}
