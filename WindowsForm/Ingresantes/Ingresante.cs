using System.Text;

namespace Ingresantes
{
    public class Ingresante
    {
        private string _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;   
        private string _pais;

        public Ingresante(string cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            _cursos = cursos;
            _direccion = direccion;
            _edad = edad;
            _genero = genero;
            _nombre = nombre;
            _pais = pais;
        }

        public string Mostrar() 
        {
            StringBuilder ingresanteSB = new StringBuilder();
            ingresanteSB.AppendLine($"nombre {this._nombre}");
            ingresanteSB.AppendLine($"direccion {this._direccion}");
            ingresanteSB.AppendLine($"edad {this._edad}");
            ingresanteSB.AppendLine($"genero {this._genero}");
            ingresanteSB.AppendLine($"pais {this._pais}");
            ingresanteSB.AppendLine($"Curso/s \n{this._cursos}");
            return ingresanteSB.ToString();
        }
    }
}