using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales
{
    public class Perro : animal
    {
        public override void Saludar() 
        {
            Console.WriteLine("woooff");
        }
    }
}
