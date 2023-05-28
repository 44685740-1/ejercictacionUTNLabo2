

namespace recorrerStringForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Ahuitz";

            foreach (var item in nombre) 
            {
                Console.Write($"{item}");
            }
        }
    }
}