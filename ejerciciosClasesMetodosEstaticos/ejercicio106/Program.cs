using bibliotecaInputs;
using ClaculadoraDeArea;
namespace ejercicio106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double retorno;
            if (inputs.PedirUnNumeroEntero(out int numero))
            {
                retorno = CalculadoraDeArea.CalcularAreaCirculo(numero);    
                Console.WriteLine($"el area del circulo es {retorno}");
            }
            else 
            {
                
            }
            
        }
    }
}