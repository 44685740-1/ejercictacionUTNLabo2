using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio101
{
    internal class Cuenta
    {
        public string titular;
        public double cantidad;

        //constructor con parametros
        public Cuenta(string titular, double cantidad) 
        {
            this.titular = titular; 
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }
        public double GetCantidad()
        {
            return cantidad;
        }

        public string MostrarCuenta()
        {
            StringBuilder stringCuenta = new StringBuilder();
            stringCuenta.Append("titular: ");
            stringCuenta.AppendLine(this.titular);
            stringCuenta.Append("cantidad: ");
            stringCuenta.Append(this.cantidad.ToString());
            return stringCuenta.ToString();
        }

        public void Ingresar(double MontoAcreditar)
        {
            if (MontoAcreditar > 0)
            {
                this.cantidad += MontoAcreditar;
                Console.WriteLine(this.cantidad.ToString());
            }
        }

        public void retirar(double MontoDebitar)
        {
            if (MontoDebitar > 0)
            {
                this.cantidad -= MontoDebitar;
                Console.WriteLine(this.cantidad.ToString());
                {
                }
            }

        }
    }
}
