using ejercicio102;
namespace ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personaUnoString;
            string personaDosString;
            string personaTresString;
            Persona personaUno = new Persona("Ahuitz", 2003, 2, 3, 44685740);
            Persona personaDos = new Persona("Carolina", 1979, 1, 25, 27088891);
            Persona personaTres = new Persona("Gael", 2021, 10, 5, 50779856);

            personaUnoString = personaUno.Mostrar();
            personaDosString = personaDos.Mostrar();
            personaTresString = personaTres.Mostrar();

            Console.WriteLine(personaUnoString);
            Console.WriteLine(personaDosString);
            Console.WriteLine(personaTresString);

            if (personaUno.EsMayorEdad())
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("es menor de edad");
            }

            if (personaDos.EsMayorEdad())
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("es menor de edad");
            }



            if (personaTres.EsMayorEdad())
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("es menor de edad");
            }

        }
    }
}