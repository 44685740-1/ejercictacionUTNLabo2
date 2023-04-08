using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioA01
{
    internal class factorial
    {
        public static int CalcularFactorial(int numero) 
        {
            //tambien se puede hacer con recursion
            //importante inicializar el acumulador de factorial en uno
            int factorial = 1;
            if (numero > 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine(i);
                    factorial *= i;
                }
                return factorial;
            }
            else
            {
                return 0;
            }
        }
    }
}
