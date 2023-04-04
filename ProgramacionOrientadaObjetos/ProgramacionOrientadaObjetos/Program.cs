using ejecicio101;
using System.Diagnostics;

namespace ejercicio101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double retornoGetCantidad;
            string retornoGetTitular;
            string muestraAtributosDeCuenta;
            //instancio la clase cuenta
            Cuenta cuentaUno= new Cuenta();
            Console.WriteLine("ingrese la opcion que desea");
            if (int.TryParse(Console.ReadLine(), out int opcion)) 
            {
               // do
                //{
                    switch (opcion)
                    {
                        case 1:
                            cuentaUno.Inicializar();
                            break;
                        case 2:
                            retornoGetTitular = cuentaUno.GetTitular();
                            break;
                        case 3:
                            retornoGetCantidad = cuentaUno.GetCantidad();
                            break;
                        case 4:
                            muestraAtributosDeCuenta = cuentaUno.MostrarCuenta();
                            Console.WriteLine(muestraAtributosDeCuenta);
                            break;
                        case 5:
                            cuentaUno.Ingresar(100);
                            break;
                        case 6:
                            cuentaUno.retirar(50);
                            break;
                        case 7:
                            Console.WriteLine("saliste");
                            break;
                    }
                //} while (opcion != 7);
            }
            else
            {
                Console.WriteLine("mal ingresado");
            }
        }
    }
}