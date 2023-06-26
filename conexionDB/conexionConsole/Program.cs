namespace conexionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * PRUEBA PARA COMEXION ESTATICA
            List<usuario> listausuarios = new List<usuario>();
            List<producto> listaProductos = new List<producto>();

            listausuarios = ConexionDB.leer(listausuarios);
            listaProductos = ConexionDB.leer(listaProductos);

            foreach (producto item in listaProductos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=======================================");

            foreach (usuario item in listausuarios)
            {
                Console.WriteLine(item);
            }
            */

            
             /* CONJUNTO QUE DEBERIA ESTAR EN EL CONTROLLER
            List<usuario> listaUsuarios = new List<usuario>();
            ConexionSQL conexionSQL = new ConexionSQL();
            conexionSQL.Abrir();
            UsuariosHandler usuariosHandler = new UsuariosHandler();
            listaUsuarios = usuariosHandler.Leer();
           

            foreach (usuario item in listaUsuarios)
            {
                Console.WriteLine(item);
            }
            */


            /*
             * CONJUNTO QUE DEBERIA ESTAR EN CONTROLLER
            List<producto> listaProductos = new List<producto>();   
            ConexionSQL conexionSQL = new ConexionSQL();
            conexionSQL.Abrir();
            ProductosHandlre productosHandlre = new ProductosHandlre();
            listaProductos = productosHandlre.Leer();
            foreach (producto item in listaProductos)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}