using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_operadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            OPERADORES ARITMETICOS:
                - operador suma (+)
                - operador resta (-)
                - operador multiplicacion (*)
                - operador division (/)
                - operador resto o modulo(%)

             
             */

            // suma
            byte suma;

            suma = 6 + 2;

            Console.WriteLine(suma);

            // division real
            double divisionReal;

            divisionReal = 5.3 / 4;

            Console.WriteLine(divisionReal);

            // division enteros
            int divisionEnteros;

            divisionEnteros = 7 / 2;
            Console.WriteLine(divisionEnteros);

            // resto de una division
            int resto;

            resto  = 7 % 2;
            Console.WriteLine(resto);
        }


        }
    }
}
