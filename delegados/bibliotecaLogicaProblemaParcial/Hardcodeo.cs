using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaLogicaProblemaParcial
{
    public static class Hardcodeo
    {

        public static List<Productos> HardcodearProductos()
        {
            List<Productos> listaProductos = new List<Productos>();

            listaProductos.Add(new Productos("coca cola", 20, 13));
            listaProductos.Add(new Productos("caramelo fizz", 20, 13));
            listaProductos.Add(new Productos("sugus", 20, 25));
            listaProductos.Add(new Productos("rodesia", 20, 10));
            listaProductos.Add(new Productos("mogul", 30, 15));
            listaProductos.Add(new Productos("seven up", 40, 20));
            listaProductos.Add(new Productos("manaos", 50, 35));

            return listaProductos;  
        }
    }
}
