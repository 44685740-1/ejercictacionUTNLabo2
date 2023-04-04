namespace ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string numeroString;
            int acumulador = 0;
            char respuesta;
            int retornoValidacionNumero;
            bool retornoValidacionRespuesta = false;
            do {
                Console.WriteLine("ingrese un nuemro para sumar");
                //forma correcta de validar los datos, ponemos el readline donde iria el numeroString
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador += numero;
                    Console.WriteLine("suma: {0}", acumulador);
                    Console.WriteLine("¿Desea continuar? (S/N)");
                    if (char.TryParse(Console.ReadLine(), out respuesta) == true) 
                    {
                        retornoValidacionRespuesta = validador.ValidarRespuesta(respuesta);
                    }
                    else
                    {
                        break;
                    }
                }
                else 
                {
                    break;
                }
                
            } while (retornoValidacionRespuesta == true);


        }

        public class validador 
        {
            public static bool ValidarRespuesta(char respuesta) 
            {
                if (respuesta == 's')
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