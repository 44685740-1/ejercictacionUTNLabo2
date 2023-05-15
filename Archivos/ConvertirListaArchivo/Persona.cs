using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirListaArchivo
{
    public class Persona
    {
        private string _nombre;
        private int _edad;


        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }


        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public override string ToString()
        {
            return $"{this.Nombre},{this.Edad}";
        }

    }
}
