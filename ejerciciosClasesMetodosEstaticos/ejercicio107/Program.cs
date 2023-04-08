using bibliotecaInputs;
namespace ejercicio107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catetoUno;
            int catetoDos;
            double retornoHipotenusa;
            if (inputs.PedirUnNumeroEntero(out catetoUno))
            {
                if (inputs.PedirUnNumeroEntero(out catetoDos))
                {
                    retornoHipotenusa = Pitagoras.CalcularHipotenusa(catetoUno, catetoDos);
                    Console.WriteLine($"la hipotenusa es: {retornoHipotenusa}");
                }
                else
                {
                    Console.WriteLine("mal ingresado");
                }
            }
            else 
            {
                Console.WriteLine("mal ingresado");
            }
        }
    }
}