using bibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitariosCalculadora
{
    [TestClass]
    public class Sumar
    {
        [TestMethod]
        public void SumarDosNumeros() 
        {
            int a = 3;
            int b = 2;
            int resultado = Calculadora.Sumar(a, b);    
            Assert.AreEqual(5,resultado);      
        }
    }
}
