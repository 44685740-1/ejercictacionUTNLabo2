using bibliotecaInputs;
namespace bibliotecaInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;

            if (inputs.PedirUnTexto(out texto, 5)) 
            {
                Console.WriteLine(texto);
            }
            else
            {
                Console.WriteLine("texto demasiado grande");
                Console.WriteLine(texto);
            }

        }
    }
}