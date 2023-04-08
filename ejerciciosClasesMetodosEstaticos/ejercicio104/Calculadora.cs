using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio104
{
    internal class Calculadora
    {
        public static double Calcular(int primerOperando, int segundoOperando, char operando) 
        {
            if (operando == '+')
            {
                return primerOperando + segundoOperando;
            }
            else 
            {
                if (operando == '-') 
                {
                    return primerOperando - segundoOperando;
                }
                else
                {
                    if (operando == '*')
                    {
                        return primerOperando * segundoOperando;
                    }
                    else
                    {
                        if (operando == '/') 
                        {
                            return primerOperando / segundoOperando;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }

    /*
    public static bool Validar(int segundoOperando) 
    {
        if (segundoOperando != 0) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    */
}
