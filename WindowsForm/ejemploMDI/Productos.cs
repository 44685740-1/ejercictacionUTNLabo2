using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMDI
{
    public class Productos
    {
        private string _nombre;
        private int _precio;
        private int _cantidad;
        private string _codigoDeBarras;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string CodigoDeBarras { get => _codigoDeBarras; set => _codigoDeBarras = value; }


        public Productos(string nombre, int precio, int cantidad, string codigoDeBarras)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            CodigoDeBarras = codigoDeBarras;
        }

      
    }
}
