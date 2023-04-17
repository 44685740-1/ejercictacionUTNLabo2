using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejemploSobrecarga
{
    public class Persona
    {
        private string _nombre;
        private int _edad;
        private int _dni;

        public Persona(string nombre, int edad, int dni)
        {
            this._nombre = nombre;
            this._edad = edad;
            this._dni = dni;
        }

        //getters 
        public string Nombre{ get { return _nombre;} }
        public int Edad { get { return _edad;} }
        public int Dni { get { return _dni;} }

        //sobrecarga de operadores

        public static bool operator ==(Persona personaUno, Persona personaDos) 
        {
            return personaUno.Dni == personaDos.Dni;
        }

        //tambien hay que definir si o si el no es igual
        public static bool operator !=(Persona personaUno, Persona personaDos) 
        {
            //return p1.Legajo != p2.Legajo;
            //como ya hicimos la sobrecarga arriba
            //retorna false si son iguales
            //retorna true si no son iguales
            return !(personaUno == personaDos);
        }

        public static int operator +(Persona personaUno, Persona personaDos) 
        {
            return personaUno.Edad + personaDos.Edad;
        }

        public static explicit operator string(Persona personaUno)
        {
            StringBuilder personaSB = new StringBuilder();
            personaSB.AppendLine($"nombre {personaUno.Nombre}");
            personaSB.AppendLine($"edad {personaUno.Edad}");
            personaSB.AppendLine($"dni {personaUno.Dni}");
            return personaSB.ToString();
        }

        public static explicit operator int(Persona personaUno) 
        {
            return personaUno.Edad;
        }

        public static bool operator >(Persona personaUno, Persona personaDos) 
        {
            return personaUno.Edad > personaDos.Edad;
        }

        public static bool operator <(Persona personaUno, Persona personaDos)
        {
            return personaUno.Edad < personaDos.Edad;
        }


    }

    
}
