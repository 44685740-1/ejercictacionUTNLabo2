using System.Security.Cryptography.X509Certificates;

namespace delegadosEjemplo
{
    internal class Program
    {
        public delegate int RealizarUnCalculo(int a, int b);
        
        static void Main(string[] args)
        {
            RealizarUnCalculo SumarDosNumeros = (a, b) => a + b;
            RealizarUnCalculo restarDosNumeros = (a,b) => a - b;    
            RealizarUnCalculo MultiplicarDosNumeros = (a,b) => a * b;  
            RealizarUnCalculo DividirDosNumeros = (a,b) => a / b;
            
            List<RealizarUnCalculo> listadelegadosCalculo = new List<RealizarUnCalculo>();

            listadelegadosCalculo.Add(SumarDosNumeros);
            listadelegadosCalculo.Add(restarDosNumeros);
            listadelegadosCalculo.Add(MultiplicarDosNumeros);
            listadelegadosCalculo.Add(DividirDosNumeros);

            foreach (RealizarUnCalculo item in listadelegadosCalculo)
            {
                int retorno = item(5, 5);
                Console.WriteLine(retorno);
            }
        }
    }
}