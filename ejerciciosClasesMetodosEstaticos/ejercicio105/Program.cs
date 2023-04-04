using bibliotecaInputs;
using System.Text;
using tablaMultiplicacion;
namespace ejercicio105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retornoTablaMultiplicar;
            if (inputs.PedirUnNumeroEntero(out int numero)) 
            {
                retornoTablaMultiplicar =  TablasDeMultiplicar.GenerarTablaDeMultiplicar(numero);
                Console.WriteLine(retornoTablaMultiplicar);

            }
            else
            {
                Console.WriteLine("mal ingresado");
            }

        }


    }
}