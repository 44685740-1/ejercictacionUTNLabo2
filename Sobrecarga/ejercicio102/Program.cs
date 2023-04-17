using Billetes;
namespace ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolarUno = new Dolar(20);
            Euro euroUno = new Euro(50);
            Pesos pesosUno = new Pesos(60);

            Console.WriteLine("valores inciales");
            Console.WriteLine($"doalar {dolarUno.Cantidad}");
            Console.WriteLine($"euro {euroUno.Cantidad}");
            Console.WriteLine($"pesos {pesosUno.Cantidad}");
        }
    }
}