namespace delgadosEjemploCuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> Operacion  = n => n * n;

            Console.WriteLine(Operacion(5));
            
        }
    }
}