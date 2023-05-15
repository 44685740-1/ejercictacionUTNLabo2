using System.Text;

namespace EjemploArchivoLeerEspecifico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un Archivo en el Escritorio
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("Una clase es el tipo de dato más poderoso en C#.");
            //stringBuilder.AppendLine("Como una estructura, una clase define datos y comportamiento para el tipo de dato.");

            //File.WriteAllText("C:\\Users\\ahuit\\OneDrive\\Escritorio\\MiArchivo.txt", stringBuilder.ToString());

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Una clase es el tipo de dato más poderoso en C#.");
            stringBuilder.AppendLine("Como una estructura, una clase define datos y comportamiento para el tipo de dato.");

            File.WriteAllText("MiArchivo.txt", stringBuilder.ToString());

            bool existe = File.Exists("MiArchivo.txt");
            Console.WriteLine($"¿Existe el archivo?: {existe}");
            string textoDelArchivo = File.ReadAllText("MiArchivo.txt");
            Console.WriteLine(textoDelArchivo);
        }
    }
}