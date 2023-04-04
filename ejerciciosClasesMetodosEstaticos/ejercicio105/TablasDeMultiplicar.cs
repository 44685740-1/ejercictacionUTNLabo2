using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaMultiplicacion
{
    internal class TablasDeMultiplicar
    {
        public static string GenerarTablaDeMultiplicar(int numero) 
        {
            int resultadoMultiplicacion;
            string tablaString;
            StringBuilder tabla = new StringBuilder();
            tabla.Append($"la tabla de multiplicar del numero {numero}:\n");
            for(int i = 1; i <= 10; i++) 
            {
                resultadoMultiplicacion = numero * i;
                tabla.Append(numero.ToString());
                tabla.Append(" x "); 
                tabla.Append(i.ToString()); 
                tabla.Append(" = "); 
                tabla.Append(resultadoMultiplicacion.ToString());
                tabla.AppendLine();
            }
            //convierto string builder en un objeto string para pasar por retorno
            tablaString = tabla.ToString();
            return tablaString;
        }
    }
}
