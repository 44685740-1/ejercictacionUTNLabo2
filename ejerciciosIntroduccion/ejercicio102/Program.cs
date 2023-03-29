namespace ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            double numero;
            double numeroCuadrado;
            double numeroCubo;
            Console.WriteLine("ingrese un numero");
            numeroString = Console.ReadLine();
            numero = int.Parse(numeroString);
            if (numero > 0)
            {
                numeroCuadrado = Math.Pow(numero, 2);
                numeroCubo = Math.Pow(numero, 3);
                Console.WriteLine("el cuadrado de {0}, es {1}", numero, numeroCuadrado);
                Console.WriteLine("el cubo de {0}, es {1}", numero, numeroCubo);
            }
            else
            {
                Console.WriteLine("ERROR, reingresar numero");
            }
        }
    }
}