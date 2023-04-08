using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio107
{
    internal class Pitagoras
    {
        public static double CalcularHipotenusa(int catetoUno, int catetoDos)
        {
            if (catetoUno > 0 && catetoDos > 0)
            {
                double hipotenusa;
                double sumaCatetosAlCuadrado;
                sumaCatetosAlCuadrado = Math.Pow(catetoUno, 2) + Math.Pow(catetoDos, 2);
                hipotenusa = Math.Sqrt(sumaCatetosAlCuadrado);
                return hipotenusa;
            }
            else 
            {
                return 0;
            }
        }
    }
}
