using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesEjemplo
{
    public class Animal : IMensaje
    {
        private string _nombre;
        private int _edad;
        private string _raza;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Raza { get => _raza; set => _raza = value; }


        public Animal(string nombre, int edad, string raza)
        {
            _nombre = nombre;
            _edad = edad;
            _raza = raza;
        }

        public string EscribirMensaje()
        {
            return "soy animal";
        }
    }
}
