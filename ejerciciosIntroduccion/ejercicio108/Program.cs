﻿namespace ejercicio108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, lineaActual, asteriscos;

            Console.WriteLine("ingrese la altura del triangulo");

            if (int.TryParse(Console.ReadLine(), out altura) && altura > 0)
            {
                for (lineaActual = 1; lineaActual <= altura; lineaActual++)
                {
                    for (asteriscos = 0; asteriscos < (lineaActual * 2) - 1; asteriscos++)
                    {
                        Console.Write('*');
                    }
                    //enter
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("valor no valido");
            }
        }
    }
}