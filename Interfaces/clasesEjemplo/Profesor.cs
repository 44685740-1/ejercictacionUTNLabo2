using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesEjemplo
{
    public class Profesor:Persona,IMensaje
    {
        private int _legajo;

        public int Legajo { get => _legajo; set => _legajo = value; }

        public Profesor(string nombre, string mail, int edad, int legajo)
        :base(nombre,mail,edad)
        {
            
        }

        string IMensaje.EscribirMensaje() 
        {
            return "soy profesor";
        }
    }
}
