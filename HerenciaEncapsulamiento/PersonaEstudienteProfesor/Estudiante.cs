using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PersonaEstudienteProfesor
{
    public class Estudiante : persona
    {
        private int _calificacion;

        public int Calificacion 
        {
            get => _calificacion;   
            set => _calificacion = value;
        }

        public Estudiante(string nombre, string apellido, int edad, int dni, int calificacion)
        :base(nombre, apellido, edad, dni)
        {
            this._calificacion = calificacion;
        }

        public string Mostrar()
        {
            StringBuilder estudianteSB = new StringBuilder();
            estudianteSB.AppendLine($"nombre {this.Nombre}");
            estudianteSB.AppendLine($"apellido {this.Apellido}");
            estudianteSB.AppendLine($"edad {this.Edad}");
            estudianteSB.AppendLine($"dni {this.Dni}");
            estudianteSB.AppendLine($"calificacion {this.Calificacion}");
            return estudianteSB.ToString();
        }


    }
}
