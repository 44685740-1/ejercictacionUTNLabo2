using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public  class Kelvin
    {
        private double _temperaturaKelvin;

        //solo el getter solo lectura
        public double temperaturakelvin { get { return _temperaturaKelvin;} }
        public Kelvin(int temperaturaKelvin) 
        {
            this._temperaturaKelvin = temperaturaKelvin;    
        }

        public double CalcularTemperatura(Kelvin kelvinUno) 
        {
            return kelvinUno.temperaturakelvin * 1.8 - 459.67;
        }

        public double CalcularTemperatura(double fahrenhit) 
        {
            return (fahrenhit - 32) * 5/9;
        }
    }
}
