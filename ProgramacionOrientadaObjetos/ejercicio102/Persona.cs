using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio102
{
    internal class Persona
    {
        //atributos en privado para encapsular
        //solo puedo acceder con los getter, y no desde antes con instancia.nombre
        private string nombre;
        private DateTime fechaNaciemiento;
        private int dni;

        public Persona(string nombre, int anio, int mes, int dia, int dni) 
        {
            SetNombre(nombre);
            SetFechaNacimiento(anio, mes, dia);
            SetDni(dni);
        }

        //setters
        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(int anio, int mes, int dia) 
        {
            fechaNaciemiento = new DateTime(anio, mes, dia);
        }


        public void SetDni(int dni) 
        {
            this.dni = dni;
        }

        //getters

        public string GetNombre() 
        {
            return nombre;
        }

        public DateTime GetFechaNacimiento() 
        {
            return fechaNaciemiento;
        }

        public int GetDni() 
        {
            return dni;
        }

        private double CalcularEdad() 
        {
            double dias;
            TimeSpan diferenciaDias;
            DateTime fechaActual = DateTime.Now;
            diferenciaDias = fechaActual.Subtract(fechaNaciemiento);
            dias = diferenciaDias.TotalDays;
            //divido los dias por 365 para obtener la cantidad de años de la persona
            return Math.Floor(dias / 365);
        }

        public string Mostrar() 
        {
            StringBuilder personaString = new StringBuilder();
            personaString.AppendLine($"nombre {nombre}");
            personaString.AppendLine($"fecha de nacimiento {fechaNaciemiento.ToString()}");
            personaString.AppendLine($"dni {dni}");
            double edad;
            edad = CalcularEdad();
            personaString.AppendLine($"edad {edad}");
            return personaString.ToString();
        }

        public bool EsMayorEdad() 
        {
            double edad;
            edad = CalcularEdad();
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
