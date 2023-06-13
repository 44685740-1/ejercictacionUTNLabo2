namespace delgadosEjemploSort
{
    internal class Program
    {
        public delegate int Comparasion(int numUno, int numDos);  

        /*
        public static int CompararMenorMayor(int numUno, int numDos)
        {
            return numUno - numDos;
        }

        public static int CompararMayorMenor(int numUno, int numDos)
        {
            return numDos - numUno;
        }
        */        
        static void Main(string[] args)
        {
            
            Comparasion comparacionMayorMenor = (a,b) => b - a;
            Comparasion comparacionMenorMayor = (a,b) => a - b;
            
            List<int> listNumeros = new List<int>();
            listNumeros.Add(8);
            listNumeros.Add(10);
            listNumeros.Add(3);
            listNumeros.Add(2);
            listNumeros.Add(9);
            listNumeros.Add(1);


            //listNumeros.Sort((a, b) => a - b);
            foreach (int item in listNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");

            //listNumeros.Sort((a, b) => b - a);
            foreach (int item in listNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}