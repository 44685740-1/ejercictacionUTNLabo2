using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio103
{
    internal class Estudiante
    {
        //los atributos privados van con _ por regla de estilo
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        //constructor estatico se ejecuta automaticamente en el primer uso de la clase
        static Estudiante() 
        {
            _random = new Random(); 
        }

        //constructor de instancia no es static
        public Estudiante(string nombre, string apellido, string legajo) 
        {
            //uso el this por la ambiguedad en el nombre de las variables
            this._nombre = nombre;
            this._apellido = apellido;  
            this._legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial) 
        {

            this._notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {

            this._notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio() 
        {
            float promedio;
            float sumaNotas;
            sumaNotas = _notaPrimerParcial + _notaSegundoParcial;
            promedio = sumaNotas / 2;
            return promedio;
        }

        public double CalcularNotaFinal() 
        {
            if (_notaPrimerParcial >= 4 && _notaSegundoParcial >= 4) 
            {
                return _random.NextDouble() * 4 + 6;
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar() 
        {
            //:0.0 para formatear flotantes muy grandes
            StringBuilder  alumno = new StringBuilder();
            alumno.AppendLine($"nombre {_nombre}");
            alumno.AppendLine($"apellido {_apellido}");
            alumno.AppendLine($"legajo {_legajo}");
            alumno.AppendLine($"nota primer parcial {_notaPrimerParcial:0.0}");
            alumno.AppendLine($"nota segundo parcial {_notaSegundoParcial:0.0}");
            float promedio;
            promedio = CalcularPromedio();
            alumno.AppendLine($"promedio {promedio:0.0}");
            double notaFinal;
            notaFinal = CalcularNotaFinal();
            if (notaFinal != -1) 
            {
                alumno.AppendLine($"nota final {notaFinal:0.0}");
            }
            else
            {
                alumno.AppendLine("alumno desaprobado");
            }

            return alumno.ToString();   
        }
    }
}
