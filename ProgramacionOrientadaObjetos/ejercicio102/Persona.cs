using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio102
{
    internal class Persona
    {
        //atributos
        public string nombre;
        public DateTime fechaDenaciemiento;
        public int dni;

        //constrcutor donde incializo los atributos con valores por defecto
        public void Inicializar() 
        { 
            this.nombre = string.Empty; 
            this.fechaDenaciemiento = DateTime.MinValue;
            this.dni = 0;
        }

        //getters para cada uno de los atributos

        public string GetNombrePersona() 
        {
            string nombrePersona;
            nombrePersona = this.nombre;
            return nombrePersona;   
        }

        public DateTime GetFechaDeNacimientoPersona()
        {
            DateTime fechaDeNacimientoPersona;
            fechaDeNacimientoPersona = this.fechaDenaciemiento;
            return fechaDeNacimientoPersona;
        }

        public int GetDniPersona() 
        { 
            int dniPersona;
            dniPersona = this.dni;
            return dniPersona;
        }

        //setters para cada uno de los atributos
        public void SetNombreDePersona(string NombreDePersona) 
        {
                this.nombre = NombreDePersona;
        }

        public void SetfechaDeNacimientoDePersona(DateTime fechaDeNacimientoDePrsona) 
        {
            this.fechaDenaciemiento = fechaDeNacimientoDePrsona;
        }

        public void SetDniDePersona(int DniPersona) 
        {
            //valido la cantidad de digitos que tiene un dini almenos en argentina
            string dniString;
            dniString = DniPersona.ToString();
            if(DniPersona > 0 && dniString.Length == 8) 
            {
                this.dni = DniPersona;               
            }
        }

        public TimeSpan calcularEdad() 
        {
            DateTime nacimientoPersona;
            TimeSpan edadDelapersona;
            nacimientoPersona = GetFechaDeNacimientoPersona();
            edadDelapersona =  DateTime.Today.Subtract(nacimientoPersona);
            return edadDelapersona;
        }

        public void mostrar() 
        {
            TimeSpan edadDeLaPersona;
            edadDeLaPersona = calcularEdad();
            Console.WriteLine($"nombre : {this.nombre} \n fecha de nacimiento: {this.fechaDenaciemiento.ToString()} \n dni: {this.dni.ToString()} \n edad: {edadDeLaPersona.ToString()}");
        }

        public string EsMayorDeEdad() 
        {
            TimeSpan edadPersona;
            edadPersona = calcularEdad();
            if (edadPersona.TotalDays > 6570)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

    }
}
