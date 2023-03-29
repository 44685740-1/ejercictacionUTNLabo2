namespace ejercicio101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool retorno;
            string numeroString;
            int contador = 0;
            bool retornoValidar;
            int acumulador = 0;

            do
            {
                Console.WriteLine("ingrese un numero");
                numeroString = Console.ReadLine();
                retorno = int.TryParse(numeroString, out numero);
                if (retorno == true)
                {
                    retornoValidar = validador.Validar(numero, -100, 100);
                    if (retornoValidar == true)
                    {
                        acumulador += numero;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("no esta en el rango");
                    }
                }
                else
                {
                    break;
                }

            } while (contador < 10);
        }

        public class validador
        {
            public static bool Validar(int valor, int minimo, int maximo)
            {
                if (valor > minimo && valor < maximo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static float promedio(int valor, int contador)
            {

                float promedio;

                promedio = valor / contador;
                if (promedio > 0)
                {
                    return promedio;
                }
                else
                {
                    return 0;
                }
            }

        
    }
    }
}