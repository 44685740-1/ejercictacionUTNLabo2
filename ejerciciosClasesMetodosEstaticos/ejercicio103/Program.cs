using ejercicio103Coversores;
namespace ejercicio103
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            if (InputDatos.PedirUnNuemeroEntero(out int numeroEntero)) 
            {
                Console.WriteLine(numeroEntero);
            }
            else
            {
                Console.WriteLine("mal ingresado");
            }

        }

        public class InputDatos 
        {
            public static bool PedirUnNuemeroEntero(out int  numero) 
            {
                bool retornoNumeroEntero;
                Console.WriteLine("ingrese un numero entero");
                retornoNumeroEntero = int.TryParse(Console.ReadLine(), out numero);
                if (retornoNumeroEntero)
                {
                    return true;
                } else 
                {
                    return false; 
                }
            }
        }
    }
}