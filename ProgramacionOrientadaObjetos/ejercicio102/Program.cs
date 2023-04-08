using ejercicio102;
namespace ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Persona personaUno = new Persona();
            Persona personaDos = new Persona();
            Persona personaTres = new Persona();
            personaUno.Inicializar();
            personaUno.SetNombreDePersona("ahuitz");
            personaUno.SetDniDePersona(44685740);
            personaUno.SetfechaDeNacimientoDePersona(DateTime.Now);
            personaUno.mostrar();
            DateTime dateTime   = DateTime.Now;
            
        }
    }
}