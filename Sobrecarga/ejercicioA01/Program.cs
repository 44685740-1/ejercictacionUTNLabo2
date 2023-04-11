using Temperatura;
namespace ejercicioA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celcius celciusUno = new Celcius(40);
            Fahrenheit fahrenheitUno = new Fahrenheit(90);
            Kelvin kelvinUno = new Kelvin(500);

            Console.WriteLine($"celcius {celciusUno.TemperaturaCelcius}");
            double Caf = celciusUno.CalcularTemperatura(celciusUno);    
            Console.WriteLine($"celcius a fahrenheit {Caf}");
            Console.WriteLine($"celciues a kelvin {celciusUno.CalcularKelvin(Caf)}");
            Console.WriteLine("====================================================");


            Console.WriteLine($"fahrenheit {fahrenheitUno.temperaturaFahrenheit}");
            Console.WriteLine($"fahrenheit a celcius {fahrenheitUno.CalcularTemperatura(fahrenheitUno)}");
            Console.WriteLine($"fahrenheit a kelvin {fahrenheitUno.Calcularkelvin(fahrenheitUno)}");
            Console.WriteLine("=========================================================");


            Console.WriteLine($"kelvin {kelvinUno.temperaturakelvin}");
            double kaF = kelvinUno.CalcularTemperatura(kelvinUno);
            Console.WriteLine($"kelvin a fahrenhit {kaF}");
            Console.WriteLine($"kelvin a celcius {kelvinUno.CalcularTemperatura(kaF)}");
            Console.WriteLine("=========================================================");

        }
    }
}