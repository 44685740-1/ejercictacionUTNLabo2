using PersonaEstudienteProfesor;
namespace herenciaEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona personaUno = new persona("ahuitz", "Caracciolo", 20, 44685740);
            //Estudiante estudienteUno = new Estudiante(personaUno.Nombre, personaUno.Apellido, personaUno.Edad, personaUno.Dni, 5);
            Estudiante estudienteUno = new Estudiante("francisco", "perez", 44, 27831276, 5);
            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine("=======================");
            Console.WriteLine(estudienteUno.Mostrar());

            List<persona> listaPersonas = new List<persona>();

            listaPersonas.Add(personaUno);
            listaPersonas.Add(estudienteUno);

            foreach (persona item in listaPersonas)
            {
                Console.WriteLine(item.Mostrar());
            }
        }
    }
}