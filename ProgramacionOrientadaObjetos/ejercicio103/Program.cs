namespace ejercicio103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoUno = new Estudiante("ahuitz", "caracciolo", "113909");
            Estudiante alumnoDos = new Estudiante("sebastian", "climent", "11289");
            Estudiante alumnoTres = new Estudiante("ezequiel", "gonzalez", "115690");

            alumnoUno.SetNotaPrimerParcial(7);
            alumnoUno.SetNotaSegundoParcial(7);

            alumnoDos.SetNotaPrimerParcial(3);
            alumnoDos.SetNotaSegundoParcial(5);

            alumnoTres.SetNotaPrimerParcial(8);
            alumnoTres.SetNotaSegundoParcial(10);

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());

        }
    }
}