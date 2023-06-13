namespace delegadosEjemploTres
{
    internal class Program
    {
        public static void Saludar(string nombre)
        {
            Console.WriteLine($"¡Hola {nombre}!");
        }

        public static void SaludarConColores(string nombre, ConsoleColor colorLetra, ConsoleColor colorFondo)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Saludar(nombre);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            Action SaludarMundo = () => {Console.WriteLine("Hola Mundo");};
            Action<string> Saludar = nombre => { Console.WriteLine($"Hola {nombre}"); };
            Action<string, ConsoleColor, ConsoleColor> saludarConColores = SaludarConColores;

            SaludarMundo();
            Saludar("Ahuitz");
            saludarConColores("Carolina", ConsoleColor.Red, ConsoleColor.Green);    
        }
    }
}