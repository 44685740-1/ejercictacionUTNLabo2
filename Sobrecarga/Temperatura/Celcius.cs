using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace Temperatura
{
    public class Celcius
    {
        private double _temperaturaCelcius;

        //solo setter de solo lectura
        public double TemperaturaCelcius { get { return _temperaturaCelcius;} }
        public Celcius(int temperaturaCelcius) 
        {
            this._temperaturaCelcius = temperaturaCelcius;
        }

        public Double CalcularTemperatura(Celcius celciusUno) 
        {
            return celciusUno._temperaturaCelcius * (1.8) + 32;
        }

        public double CalcularKelvin(double fahrenheit) 
        {
            return (fahrenheit + 459.67) * 5 / 9;
        }

       

    }
}