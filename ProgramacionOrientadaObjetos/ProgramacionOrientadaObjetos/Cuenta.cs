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

        public void Inicializar()
        {
            //inicializo con valores por defecto
            this.titular = string.Empty;
            this.cantidad = 0;
        }

        public string GetTitular()
        {
            string titular;
            titular = this.titular;
            return titular;
        }
        public double GetCantidad()
        {
            double cantidad;
            cantidad = this.cantidad;
            return cantidad;
        }

        public string MostrarCuenta()
        {
            StringBuilder stringCuenta = new StringBuilder();
            stringCuenta.Append("titular: ");
            stringCuenta.Append(this.titular);
            stringCuenta.Append(" \n cantidad: ");
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
