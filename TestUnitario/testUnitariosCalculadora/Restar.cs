using bibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitariosCalculadora
{
    [TestClass]
    public class Restar
    {
        [TestMethod]
        public void restarPorCero() 
        {
            int a = 3;
            int b = 0;
            int resultado = Calculadora.Restar(a,b);
            Assert.AreEqual(a, resultado);      
        }
    }
}
