using bibliotecaInputs;
namespace ejercicioA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int retornoFactorial;
            if (inputs.PedirUnNumeroEntero(out int numero))
            {
                retornoFactorial = factorial.CalcularFactorial(numero);
                Console.WriteLine($"el factorial de {numero} es {retornoFactorial}");
            }
            else
            {
                Console.WriteLine("mal ingresado");
            }
        }
    }
}