using ejercicio103Coversores;
using System.Text;

namespace ejercicio103
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  DECIMAL A BINARIO
            string binario;
            Console.WriteLine("ingrese un nuemro entero");
            if (int.TryParse(Console.ReadLine(), out int numeroEntero)) 
            {
                binario = Conversor.ConvertirDecimalABinario(numeroEntero);
                char[] binarioReverse = binario.ToCharArray();
                Array.Reverse(binarioReverse);
                Console.WriteLine(binarioReverse);
            }
            */

            //BINARIO A DECIMAL
            int retorno;
            Console.WriteLine("ingrese un numero binario");
            if (int.TryParse(Console.ReadLine(), out int numeroBinario)) 
            { 
                retorno = Conversor.ConvertirBinarioADecimal(numeroBinario);
                Console.WriteLine(retorno);
            } 
        }
    }
}