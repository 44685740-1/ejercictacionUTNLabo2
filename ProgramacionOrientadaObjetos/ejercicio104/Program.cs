using System.Security.Cryptography.X509Certificates;

namespace ejercicio104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliUno = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliDos = new Boligrafo(5, ConsoleColor.Red);

            
            Console.WriteLine($"Boligrafo uno color: {boliUno.GetColor()}");
            Console.WriteLine($"Boligrafo dos color: {boliDos.GetColor()}");

            //tinta antes del set tinta
            Console.WriteLine($"boligrafo uno tinta: {boliUno.GetTinta()}");
            Console.WriteLine($"boligrafo dos tinta: {boliDos.GetTinta()}");

            //despues del recargar
            /*
            boliDos.recargar();
            Console.WriteLine($"boligrafo dos tinta: {boliDos.GetTinta()}");
            */

            //despues de pintar
            boliDos.Pintar(-1, out string dibujo);
            Console.WriteLine(dibujo);

        }
    }
}