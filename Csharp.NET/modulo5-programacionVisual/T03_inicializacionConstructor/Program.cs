using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_inicializacionConstructor
{
    internal class Program
    {

        public struct CuentaBancaria
        {
            public string numeroCuenta;
            public decimal saldo;
            public string titular;

            public CuentaBancaria(string numeroCuentaPa, decimal saldoPa, string titularPa)
            {
                numeroCuenta = numeroCuentaPa;
                saldo = saldoPa;
                titular = titularPa;
            }
        }
        static void Main(string[] args)
        {
            // Inicializacion mediante constructor
            CuentaBancaria cuenta = new CuentaBancaria("987654321", 2500.00m, "Juan Perez");

            Console.WriteLine($"cuenta: {cuenta.titular}");
            Console.WriteLine($"numero: {cuenta.numeroCuenta}");
            Console.WriteLine($"saldo: {cuenta.saldo}");
        }
    }
}
