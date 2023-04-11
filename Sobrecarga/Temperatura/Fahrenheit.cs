using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        private double _temperaturaFahrenheit;

        //solo el getter solo letura
        public double temperaturaFahrenheit {get { return _temperaturaFahrenheit;} }
        public Fahrenheit(int temperaturaFahrenheit) 
        {
            this._temperaturaFahrenheit = temperaturaFahrenheit;
        }

        public Double CalcularTemperatura(Fahrenheit fahrenheitUno) 
        {
            return (fahrenheitUno.temperaturaFahrenheit - 32) * 5 / 9;
        }

        public double Calcularkelvin(Fahrenheit fahrenheitUno)
        {
            return (fahrenheitUno.temperaturaFahrenheit + 459.67) * 5 / 9;
        }

    }
}
