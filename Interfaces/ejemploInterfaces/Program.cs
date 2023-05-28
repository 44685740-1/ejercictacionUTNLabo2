using clasesEjemplo;
namespace ejemploInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Ahuitz", "ahuitz@gmail.com", 20);
            Profesor profesorUno = new Profesor("francisco", "fran@gmail.com", 44, 2789456);
            Animal animalUno = new Animal("vincent", 13, "callee");
            Perro perroUno = new Perro("harry", 12, "bull dog", true);

            //lista de mensajes proliforficos por asi decir
            List<IMensaje> mensajes = new List<IMensaje>();
            mensajes.Add(personaUno);
            mensajes.Add(profesorUno);
            mensajes.Add(animalUno);
            mensajes.Add(perroUno);

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(personaUno);
            listaPersonas.Add(profesorUno);
            /*
            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(item.EscribirMensaje());
            }
            */

            //string mensaje = ((IMensaje)profesorUno).EscribirMensaje();

            //Console.WriteLine(mensaje);
            //Una especie de polimorfismo usando el casteo necesario para que aparezca la implementacion explicita
            foreach (Persona item in listaPersonas)
            {
                string mensaje = ((IMensaje)item).EscribirMensaje();
                Console.WriteLine(mensaje);
            }
        }
    }
}