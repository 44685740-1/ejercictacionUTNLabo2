using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacionConsola
{
    public  class Persona
    {
        //los  atributos deben ser publicos si queremos serializar
        private string nombre;
        private string materia;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string materia, int edad)
        {
            this.nombre = nombre;
            this.materia = materia;
            this.edad = edad;
        }

        //constructor vacio necesario para serializar
        public Persona() 
        {
            
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Materia} {this.Edad}";
        }
    }
}
