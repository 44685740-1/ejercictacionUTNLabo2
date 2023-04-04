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
            //inicializo una instancia de strig builder
            StringBuilder sb = new StringBuilder();
            while (resultadoDivison / 2 != 1) 
            {
                resultadoDivison = resultadoDivison / 2;
            }
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            return 1;
        }
    }
}
