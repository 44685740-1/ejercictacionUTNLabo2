using Suma;
namespace ejercicio101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador();

            /*
            //conversion explicita
            int entero;
            entero = (int)sumadorUno;
            */

            /*
             * Sobrecarga de long
            long retorno;
            retorno = sumadorUno.Sumar(170, 130);
            Console.WriteLine(retorno);
            */

            /*
             * Sobrecarga de cancatenacion de strings
            string retorno;
            retorno = sumadorUno.Sumar("1", "2");
            Console.WriteLine(retorno);
            */

            /*
             * sobrecarga + suma de objetos
            long sumaObjetos;
            sumaObjetos = sumadorUno + sumadorDos;
            Console.WriteLine(sumaObjetos);
            */

            //sobrecarga operador pipe objetos
            if (sumadorUno | sumadorDos) 
            {
                Console.WriteLine("son iguales");
            }
        }
    }
}