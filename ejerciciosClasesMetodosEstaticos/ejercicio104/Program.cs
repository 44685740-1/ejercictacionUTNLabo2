using bibliotecaInputs;
using ejercicio104;
namespace ejercicio104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool retornoPrimerOperando;
            bool retornoSegundoOperando;
            int opcionOperando;
            char operando = 'a';
            double retornoCalcular;
            bool retornoValidarDivision;

            retornoPrimerOperando = inputs.PedirUnNumeroEntero(out int primerOperando);
            Console.WriteLine("ingrese la opcion que deses\n 1. + ; 2. - ; 3. * ; 4. /");
            int.TryParse(Console.ReadLine(), out opcionOperando);
            switch (opcionOperando) 
            {
                case 1:
                    operando = '+';
                    break;
                case 2:
                    operando = '-'; 
                    break;
                case 3:
                    operando = '*';
                    break;
                case 4:
                    operando = '/'; 
                    break;
            }
          
            retornoSegundoOperando = inputs.PedirUnNumeroEntero(out int segundoOperando);

            
            if (retornoPrimerOperando && retornoSegundoOperando) 
            {
                retornoCalcular = Calculadora.Calcular(primerOperando, segundoOperando, operando);
                Console.WriteLine($"el resultado es: {retornoCalcular.ToString()}");
            }
            else
            {
                Console.WriteLine("mal ingressado");
            }
        }
    }
}