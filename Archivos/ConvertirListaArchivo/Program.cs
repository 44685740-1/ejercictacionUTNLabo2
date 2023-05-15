namespace ConvertirListaArchivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Ahuitz", 20);
            Persona personaDos = new Persona("Francisco", 44);

            List<Persona> ListaPersonas  = new List<Persona>();
            
            ListaPersonas.Add(personaUno);
            ListaPersonas.Add(personaDos);
            List<string> listaStringPersonas = new List<string>();

            foreach (var persona in ListaPersonas)
            {
                listaStringPersonas.Add(persona.ToString());
            }

            string listaString = string.Join(Environment.NewLine, listaStringPersonas.ToArray());
            Console.WriteLine(listaString);

            File.WriteAllText("MiArchivo.txt", listaString);

        }
    }
}