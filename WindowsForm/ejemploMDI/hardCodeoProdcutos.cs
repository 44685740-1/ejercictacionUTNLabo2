using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMDI
{
    public static class hardCodeoProdcutos
    {
        
        public static void hardCodeo(List<Productos> productoss) 
        {
            productoss.Add(new Productos("caramelos", 15, 50, "asnjsax3210"));
            productoss.Add(new Productos("barritas", 10, 60, "cdldskc5641"));
            productoss.Add(new Productos("cigarrillos", 440, 50, "asnjsax3210"));
            productoss.Add(new Productos("chocolate", 200, 36, "asnjsax3210"));
            productoss.Add(new Productos("marroc", 125, 20, "asnjsax3210"));
            productoss.Add(new Productos("helado", 500, 30, "asnjsax3210"));
            productoss.Add(new Productos("ppizza", 15, 50, "asnjsax3210"));
            productoss.Add(new Productos("malboro", 15, 50, "asnjsax3210"));
            productoss.Add(new Productos("camel", 410, 50, "asnjsax3210"));
            productoss.Add(new Productos("parisien", 640, 50, "asnjsax3210"));
            productoss.Add(new Productos("coca", 270, 50, "asnjsax3210"));
            productoss.Add(new Productos("papas lays", 15, 50, "asnjsax3210"));
        }
        

    }
}
