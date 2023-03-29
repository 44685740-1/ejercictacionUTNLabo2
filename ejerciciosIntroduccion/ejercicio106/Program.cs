namespace ejercicio106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anioInicioString;
            string anioFinString;
            int anioInicio;
            int anioFin;
            bool retornoAnioFin;
            bool retornoAnioInicio;
            Console.WriteLine("ingrese el año de inicio");
            anioInicioString = Console.ReadLine();
            retornoAnioInicio = int.TryParse(anioInicioString, out anioInicio);
            Console.WriteLine("ingrese el año de fin");
            anioFinString = Console.ReadLine();
            retornoAnioFin = int.TryParse(anioFinString, out anioFin);
            if (retornoAnioFin == true && retornoAnioInicio == true && anioFin > anioInicio)
            {
                for (int i = anioInicio; i <= anioFin; i++)
                {
                    if (i % 4 == 0)
                    {
                        if (i % 100 != 0 || i % 400 == 0)
                        {
                            Console.WriteLine("el año {0}, es bisiesto", i);
                        }
                        else
                        {
                            //Console.WriteLine("no es bisiesto");
                        }
                    }
                    else
                    {
                        //Console.WriteLine("no es bisiesto");
                    }
                }
            }
        }
    }
}