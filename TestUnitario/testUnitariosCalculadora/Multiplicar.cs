using bibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitariosCalculadora
{
    [TestClass]
    public class Multiplicar
    {
        [TestMethod]
        public void MultiplicarDosCeros() 
        {
            int a = 0;
            int b = 0;  
            int resultado = Calculadora.Sumar(a, b);
            Assert.AreEqual(0, resultado);
        }
    }
}
