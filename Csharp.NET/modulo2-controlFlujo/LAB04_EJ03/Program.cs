using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Imprimir los números del 10 al 1 uno abajo del otro.

             */

            // inicializo variable
            int numero = 10;

            while (numero >= 1)
            {
                // muestro numero
                Console.WriteLine(numero);

                // decremento --> evitar blucle infinito
                numero--;

            }

            Console.ReadKey();
        }
    }
}
