using JugadorEquipo;
namespace ejercicioC01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Equipo equipo = new Equipo(2, "utn");
            Jugador jugadorUno = new Jugador("ahuitz", 44685740, 1, 3);
            Jugador jugadorDos = new Jugador("ahuitz", 44685740, 1, 3);
            Jugador jugadorTres = new Jugador("Carolina", 278312569, 8, 5);
            Jugador jugadorCuatro = new Jugador("juan", 18932556, 2, 3);


            if (equipo + jugadorUno)
            {
                Console.WriteLine(jugadorUno.MostarDatos());
            }

            if (equipo + jugadorDos)
            {
                Console.WriteLine(jugadorDos.MostarDatos());
            }
            else
            {
                //no se agrego porque se repite el jugador
                Console.WriteLine($"no se agrego \n{jugadorTres.MostarDatos()}");
            }

            if (equipo + jugadorTres)
            {
                Console.WriteLine(jugadorTres.MostarDatos());
            }

            if (equipo + jugadorCuatro)
            {
                Console.WriteLine(jugadorCuatro.MostarDatos());
            }
            else
            {
                //supera a 2 que es la catidad de jugadores del equipo que hardcodeamos
                Console.WriteLine($"no se agrego \n{jugadorCuatro.MostarDatos()}");
            }
        }
    }
}