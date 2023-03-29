using System.Text;

namespace ejercicio103
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");

            int numeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine(ListarNumerosPrimos(numeroIngresado));
            // Parsear el numero y pasarselo metodo
        }

        public static string ListarNumerosPrimos(int numeroTope)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 2; i <= numeroTope; i++)
            {
                // Manejar la logica de si i es primo
                if (EsPrimo(i))
                {
                    // sb.AppendFormat("{0} ,", i);
                    stringBuilder.Append($"{i} ,");
                }
            }

            return stringBuilder.ToString();
        }

        public static bool EsPrimo(int numeroTope)
        {
            for (int i = 2; i < numeroTope; i++)
            {
                if (numeroTope % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}