namespace ejemploSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Ahuitz", 20, 44685740);
            Persona personaDos = new Persona("Carolina", 44, 44685740);

            
            if (personaUno == personaDos)
            {
                Console.WriteLine("son igules");
            }
            else
            {
                Console.WriteLine("son diferentes");
            }

            int suma = personaUno + personaDos;
            Console.WriteLine(suma);

            string personaUnoString = (string)personaUno;
            Console.WriteLine(personaUnoString);

            int edadPersonaUno = (int)personaUno;
            Console.WriteLine(edadPersonaUno);

            
            if (personaUno < personaDos) 
            {
                Console.WriteLine("persona uno es menor");
            }


            
        }
    }
}