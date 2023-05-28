using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesEjemplo
{
    public class Perro:Animal,IMensaje
    {
        private bool _herido;

        public bool Herido { get => _herido; set => _herido = value; }

        public Perro(string nombre, int edad, string raza, bool herido)
        :base(nombre,edad,raza)
        { 
            
        }

        string IMensaje.EscribirMensaje() 
        {
            return "soy perro";        
        }
    }
}
