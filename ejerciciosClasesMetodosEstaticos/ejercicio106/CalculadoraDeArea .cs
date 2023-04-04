using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaculadoraDeArea
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            if (longitudLado > 0)
            {
                double areaTotal;
                areaTotal = longitudLado * longitudLado;
                return areaTotal;
            }
            else 
            {
                return 0;
            }
        }

        public static double CalcularAreaTriangulo(double baseTriangilo, double altura) 
        {
            if (altura > 0 && baseTriangilo > 0)
            {
                double areaTriangulo;
                areaTriangulo = (altura * baseTriangilo) / 2;
                return areaTriangulo;
            }
            else 
            {
                return 0;
            }
        }

        public static double CalcularAreaCirculo(double radio) 
        { 
            if (radio > 0) 
            {
                const double pi = 3.14;
                double areaCirculo;
                areaCirculo = pi * (radio * radio);
                return areaCirculo;
            }
            else
            {
                return 0;
            }

        }
    }
}
