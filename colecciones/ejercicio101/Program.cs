namespace ejercicio101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Random aleatorio = new Random();

            //añado los nuemros ramdom
            for (int i = 0; i < 20; i++)
            {
                lista.Add(aleatorio.Next(-100, 100));
            }

            //tal como es 
            foreach (int numero in lista) 
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("======================");

            
            //negativos de forma creciente
            lista.Sort();
            foreach (int numero in lista)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine("===================================================");
            //positivos de forma decreciente
            lista.Sort();
            lista.Reverse();

            foreach (int numero in lista)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

        }
    }
}