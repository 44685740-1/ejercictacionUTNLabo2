namespace ejercicio108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasTranscurridos;
            bool retornoDia;
            bool retornoMes;
            bool retornoAnio;
            Console.WriteLine("ingrese su dia de nacimiento");
            retornoDia = int.TryParse(Console.ReadLine(), out int dia);

            Console.WriteLine("ingrese su mes de nacimiento");
            retornoMes = int.TryParse(Console.ReadLine(), out int mes);

            Console.WriteLine("ingrese su año de nacimiento");
            retornoAnio =  int.TryParse(Console.ReadLine(), out int anio);

            if (retornoDia == true && retornoMes == true && retornoAnio == true)
            {
                DateTime fechaUsuario = new DateTime(anio, mes, dia);
                diasTranscurridos = fecha.calcularDiasFechaActualNacimiento(fechaUsuario);
                Console.WriteLine($"dias transcurridos {diasTranscurridos}");
            }
            else
            {
                Console.WriteLine("mal ingresado");
            }



        }
    }
}