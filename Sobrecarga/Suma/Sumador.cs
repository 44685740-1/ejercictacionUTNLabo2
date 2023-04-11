namespace Suma
{
    public class Sumador
    {
        private int _cantidadSumas;


        public Sumador(int cantidadSumas) 
        { 
            this._cantidadSumas = cantidadSumas;   
        }

        //de esta forma puedo llamar al otro constructor de la misma clase
        public Sumador():this(0) 
        {
            
        }

        public long Sumar(long a, long b) 
        {
            this._cantidadSumas += 1;
            long suma;
            suma = a + b;
            return suma;
        }

        public string Sumar(string a, string b) 
        {
            this._cantidadSumas += 1;
            string stringConcatenado;
            stringConcatenado = a + b;
            return stringConcatenado;
        }

        //sobrecarga operador +

        public static long operator +(Sumador a, Sumador b) 
        {
            long sumaCantidadSumas;
            sumaCantidadSumas = a._cantidadSumas + b._cantidadSumas;    
            return sumaCantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b) 
        {
            /*
            if (a._cantidadSumas == b._cantidadSumas) 
            {
                return true;
            }
            else
            {
                return false;
            }
            */
            //como es una sentencia booleana me puedo ahorrar el if de esta forma
            return a._cantidadSumas == b._cantidadSumas;
        }

        public static explicit operator int(Sumador sumador) 
        {
            return sumador._cantidadSumas;
        }
    }
}