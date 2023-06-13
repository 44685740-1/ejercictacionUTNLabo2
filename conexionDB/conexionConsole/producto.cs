using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace conexionConsole
{
    public class producto
    {
        private int _id; 
        private string _nombre;
        private int _precio;
        private int _cantidad;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public producto(int id, string nombre, int precio, int cantidad)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }


        public producto(string nombre, int precio, int cantidad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }

        public producto() 
        { 
            
        }

        public override string ToString()
        {
            return $"{this.Id} {this.Nombre} {this.Precio} {this.Cantidad}";
        }

        public static List<producto> ConvertirDataTableALista(DataTable dataTable)
        {
            List<producto> listaProductos = new List<producto>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                producto producto = new producto(); 
                producto.Id = Convert.ToInt32(dataTable.Rows[i]["id"]);
                producto.Nombre = dataTable.Rows[i]["nombre"].ToString();
                producto.Precio = Convert.ToInt32(dataTable.Rows[i]["precio"]);
                producto.Cantidad = Convert.ToInt32(dataTable.Rows[i]["cantidad"]);
                listaProductos.Add(producto);
            }
            return listaProductos;
        }
    }
}
