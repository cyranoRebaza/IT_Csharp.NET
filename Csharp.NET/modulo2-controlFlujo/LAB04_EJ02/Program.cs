using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir los números del 1 al 10 salteando de a 2 uno abajo
             del otro.
             
             */

            // inicializo variable
            int numero = 1;

            while (numero <= 10)
            {
                // muestro numero
                Console.WriteLine(numero);

                // incremento de a dos
                numero +=2; // numero = numero + 2;

            }

            Console.ReadKey();
        }
    }
}
