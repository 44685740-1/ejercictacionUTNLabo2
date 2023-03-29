namespace ejercicio101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            int numero = 0;
            int suma = 0;
            float promedio;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            bool flagPrimero = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero");
                numeroString = Console.ReadLine();
                numero = int.Parse(numeroString);
                suma += numero;
                if (flagPrimero == true)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                    flagPrimero = false;
                }
                else
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }

                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }

                }
            }

            promedio = suma / 5;
            Console.WriteLine("el valor maximo es {0}", numeroMaximo);
            Console.WriteLine("el valor minimo es {0}", numeroMinimo);
            Console.WriteLine("el promedio es de {0}", promedio);
        }
    }
}