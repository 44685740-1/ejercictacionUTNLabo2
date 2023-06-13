using System.Security.Cryptography.X509Certificates;

namespace delegadosEjemploDos
{
    internal class Program
    {
        public delegate void Saludar();

        public static void SaludarMundo() 
        {
            Console.WriteLine("Hola Mundo");
        }

        static void Main(string[] args)
        {
            Saludar SaludoPipi = () => {Console.WriteLine("Hola pipi");};
            Saludar mundoSaludo = SaludarMundo;
            
            List<Saludar> saludos = new List<Saludar>();    
            saludos.Add(mundoSaludo);
            saludos.Add(SaludoPipi);

            foreach (Saludar item in saludos)
            {
                item();
            }
        }
    }
}