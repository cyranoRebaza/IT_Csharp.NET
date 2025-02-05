using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_enumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            // creamos una variable tipo cuenta
            tipo_cuenta cuenta;

            // asignamos un valor
            cuenta = tipo_cuenta.cuentaCorriente;

            // pasamos de enumeracion a entero
            numero = (int)cuenta;

            // mostramos la informacion
            Console.WriteLine($"La cuenta es una {cuenta} con valor {numero}");

            // creamos una variable de tipo moneda
            moneda moneda_cuenta = moneda.pesos;

            //mostramos la informacion
            Console.WriteLine($"La cuenta es una {cuenta} en {moneda_cuenta} con valor {numero}");

            Console.ReadLine();
        }
    }

    // declaramos las enumeraciones
    public enum tipo_cuenta {cajaAhorros, cuentaCorriente, cuentaSueldo };
    public enum moneda { pesos = 1, dolares, euros, reales};
}
