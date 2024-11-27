using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_inicializacionDirecta
{
      
    
    internal class Program
    {
        public struct CuentaBancaria
        {
            public string numeroCuenta;
            public decimal saldo;
            public string titular;
        }
        
        static void Main(string[] args)
        {
            CuentaBancaria cuenta;

            // asignacion directa a los campos
            cuenta.numeroCuenta = "123456789";
            cuenta.saldo = 1500.75m;
            cuenta.titular = "Lucho Juares";

            Console.WriteLine($"cuenta: {cuenta.titular}");
            Console.WriteLine($"numero: {cuenta.numeroCuenta}");
            Console.WriteLine($"saldo: {cuenta.saldo}");
        }
    }
}
