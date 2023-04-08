using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio108
{
    internal class fecha
    {
        public static int calcularDiasFechaActualNacimiento(DateTime fechaNacimiento) 
        {
            int contadorAnioBisiesto = 0;
            int diasTranscurridos;
            TimeSpan tiempoTranscurrido;
            DateTime fechaActual = DateTime.Today;
            tiempoTranscurrido = fechaActual.Subtract(fechaNacimiento);
            diasTranscurridos = tiempoTranscurrido.Days;
            for (int i = fechaNacimiento.Year; i <= fechaActual.Year; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 != 0 || i % 400 == 0)
                    {
                        contadorAnioBisiesto++;
                    }
                    else
                    {
                        //no es bisiesto
                    }
                }
                else
                {
                    //no es bisesto
                }
            }

            if (contadorAnioBisiesto > 0) 
            {
                Console.WriteLine($"dias transcurridos sin sumar los dias de los añosbsiestos {diasTranscurridos}");
                diasTranscurridos = diasTranscurridos + contadorAnioBisiesto;
            }

            return diasTranscurridos;
        }

    }
}
