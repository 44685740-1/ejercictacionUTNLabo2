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
            float promedio = 0;
            int maximo = 0;
            int minimo = 0;
            bool flagPrimero = true;

            do
            {
                //se podria extraer esta logica de pedir el input al usuario por medio de un metodo
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
                        promedio =  validador.promedio(acumulador, contador);
                        validador.MaximoMinimo(numero, ref maximo, ref minimo, ref  flagPrimero);
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
            Console.WriteLine(" promedio {0}\n maximo {1}\n minimo {2}",promedio, maximo, minimo);
        }

        public class validador
        {
            public static bool Validar(int valor, int minimo, int maximo)
            {
                /*
                if (valor > minimo && valor < maximo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                */
                //de esta forma me ahorro el if ya que es una éxpresion booleana
                return valor > minimo && valor < maximo;
            }


            public static float promedio(int valor, int contador)
            {

                float promedio;
                //casteo
                promedio = (float)valor / (float)contador;
                if (promedio > 0)
                {
                    return promedio;
                }
                else
                {
                    return 0;
                }
            }

            public static void MaximoMinimo(int numero, ref int maximo, ref int minimo, ref bool flagPrimero) 
            {
               
                if (flagPrimero == true)
                {
                    maximo = numero;
                    minimo = numero;
                    flagPrimero = false;
                }
                else
                {

                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

            }
        
        
    }
    }
}