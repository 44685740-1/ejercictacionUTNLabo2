using Veterinaria;
namespace ejercicioA02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimentoMascotaUno = new DateTime(2015, 6, 9);
            DateTime nacimentoMascotaDos = new DateTime(2018, 10, 6);
            DateTime nacimentoMascotaTres = new DateTime(2012, 2, 17);
            DateTime nacimentoMascotaCuatro = new DateTime(2017, 8, 20);

            //perro sin vacunar
            Mascota mascotaUno = new Mascota("harry", " perro bulldog", nacimentoMascotaUno, "-");

            //gato con la vacuna triple felina
            Mascota mascotaDos = new Mascota("vincent", "gato manchado", nacimentoMascotaDos, "triple felina");

            //gato sin vacunas
            Mascota mascotaTres = new Mascota("negri", "gato negro", nacimentoMascotaTres, "-");

            //perro con vacuna para la rabia
            Mascota mascotaCuatro = new Mascota("lucy", "perra gris", nacimentoMascotaCuatro, "rabia");

            
            Cliente clienteIUno = new Cliente("maure 2574", "ahuitz", "caracciolo", "1131831276");
            clienteIUno.Mascota = mascotaUno;
            Cliente clienteDos = new Cliente("zapiola 1013", "carolina", "gangi", "124556975");
            clienteDos.Mascota = mascotaDos;
            Cliente clienteTres = new Cliente("zabala 2408", "martin", "lamas", "546879123");
            clienteTres.Mascota = mascotaTres;
            clienteTres.Mascota = mascotaCuatro;
            /*
            Console.WriteLine(clienteIUno.MostrarCliente());
            Console.WriteLine(mascotaUno.MostrarMascota());
            Console.WriteLine(clienteDos.MostrarCliente());
            Console.WriteLine(mascotaDos.MostrarMascota());
            Console.WriteLine(clienteTres.MostrarCliente());
            Console.WriteLine(mascotaTres.MostrarMascota());
            Console.WriteLine(mascotaCuatro.MostrarMascota());
            */
            
            Console.WriteLine(clienteIUno.MostrarCliente());
            Console.WriteLine(clienteDos.MostrarCliente());
            Console.WriteLine(clienteTres.MostrarCliente());
            
        }
    }
}