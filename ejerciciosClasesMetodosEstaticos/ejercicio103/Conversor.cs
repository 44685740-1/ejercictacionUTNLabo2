using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//el nameEspace se usa pra reconocer a la clase en el main
namespace ejercicio103Coversores
{
    internal class Conversor
    {
        //static hace que el metodo sea exclusivo de la clase
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            int resultadoDivison;
            StringBuilder binario = new StringBuilder();
            do
            {   
                if (numeroEntero % 2 == 0)
                {
                    binario.Append("0");
                }
                else
                {
                    binario.Append("1");
                }
                numeroEntero /= 2;
            } while (numeroEntero > 0);
            return binario.ToString();  
        }

        public static int ConvertirBinarioADecimal(int numeroBinario) 
        {
            int numeroDecimal = 0;
            int baseValor = 1;

            while (numeroBinario > 0)
            {
                int resto = numeroBinario % 10;
                numeroBinario /= 10;

                if (resto == 1)
                {
                    numeroDecimal += baseValor;
                }
                baseValor *= 2;
            }

            return numeroDecimal;
        }
    }
}
