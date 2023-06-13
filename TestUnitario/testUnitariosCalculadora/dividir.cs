using bibliotecaCalculadora;

namespace testUnitariosCalculadora
{
    [TestClass]
    public class dividir
    {
        [TestMethod]
        [ExpectedException (typeof (DivideByZeroException))]
        public void DividirPorCero()
        {
            int a = 5;
            int b = 0;
            int resultado = Calculadora.Dividir(a, b);
        }
    }
}