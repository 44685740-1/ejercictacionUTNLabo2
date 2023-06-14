namespace serializacionConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Ahuitz Caracciolo","matematica",20);
            Persona personaDos = new Persona("Francisco Caracciolo", "arte", 44);
            Persona personaTres = new Persona("Roman Caracciolo", "teatro", 65);
            Persona personaCuatro = new Persona("Carolina Gangi", "kisoko", 43);

            List<Persona> listaPersonas = new List<Persona>();
            
            listaPersonas.Add(personaUno);  
            listaPersonas.Add(personaDos);
            listaPersonas.Add(personaTres);
            listaPersonas.Add(personaCuatro);

            //instancia de la clase serializador generica
            var Serializador = new Serializador<List<Persona>>();
            /*
             * SERIALIZAR XML
            Serializador.SerializarXML(listaPersonas, "personas.xml");
            List<Persona> listaPersonasDos = new List<Persona>();
            listaPersonasDos = Serializador.DeserializarXMl("personas.xml");
            foreach (var item in listaPersonasDos)
            {
                Console.WriteLine(item);
            }
            */


            Serializador.SerializarJSON(listaPersonas, "personas.json");
            List<Persona> listaPersonasDos = new List<Persona>();
            listaPersonasDos = Serializador.DeserializarJSON("personas.json");
            foreach (var item in listaPersonasDos)
            {
                Console.WriteLine(item);
            }

            /*
             * LLAMADA CSV
             * SERIALIZAR
             *  Serializador.SerializarCSV(listaPersonas, "personas.csv");
             *  DESCERIALIZAR
            List<Persona> listaPersonasDos = new List<Persona>();
            listaPersonasDos = Serializador.DeserializarCSV<Persona>("personas.csv");
            */
        }
    }
}