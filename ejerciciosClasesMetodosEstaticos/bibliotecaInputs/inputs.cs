using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaInputs
{
    //public class porque la voy a usar en todos los proyectos de la solucion
    //por defecto genera una internal class
    public class inputs
    {
        public static bool PedirUnNumeroEntero(out int numero)
        {
            Console.WriteLine("ingrese un numero entero");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PedirUnNumeroFlotante(out float numero) 
        {
            Console.WriteLine("ingrese un numero flotante");
            if (float.TryParse(Console.ReadLine(), out numero)) 
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

        public static bool PedirUnTexto(out string textoEjemplo,int longitud)
        {
            int longitudString;
            Console.WriteLine("ingrese un texto");
            textoEjemplo = Console.ReadLine();
            longitudString = textoEjemplo.Length;
            if (longitudString <= longitud) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
