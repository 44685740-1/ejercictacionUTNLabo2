using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio104
{
    internal class Boligrafo
    {
        const short tintaMaxima = 100;
        public short cantidadTintaMaxima = tintaMaxima;
        private ConsoleColor _color;
        private short _tinta;

        //constructor, no hay trasformacion de datos
        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this._tinta = tinta;
            this._color = color;    
        }

        public ConsoleColor GetColor()
        {
            return _color;
        }

        public short GetTinta() 
        {
            return _tinta;
        }

        private void SetTinta(short tinta) 
        {
                short resultado;
                //si es negativo resta y si es positivo suma
                resultado = (short)(_tinta + tinta);
                if (resultado >= 0 &&  resultado <= cantidadTintaMaxima) 
                {
                    this._tinta = resultado;
                } 
        }

        public void recargar() 
        {
            short diferencia;
            diferencia = (short)(cantidadTintaMaxima - _tinta);
            //el setter se encarga de asignar y de hacer las validaciones
            SetTinta(diferencia);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder dibujoSB = new StringBuilder();
            int gastoPositivo;
            gastoPositivo = gasto * -1;
            if (_tinta == 0) 
            {
                //no funciona pero si ingresa 0 no muestra nada de todas formas
                dibujo = " ";
            }
            else
            {
                if(gastoPositivo <= _tinta) 
                {
                    for (int i = 1; i <= gastoPositivo; i++)
                    {
                        dibujoSB.Append("*");
                    }
                }
                else
                {
                    if (gastoPositivo > _tinta) 
                    {
                        for (int  i = 1;  i <= _tinta;  i++)
                        {
                            dibujoSB.Append("*");
                        }
                    }
                }
            }

            dibujo = dibujoSB.ToString();
            //muy importante hacer el set al final de todo
            SetTinta(gasto);
            return true;
        }

    }
}
