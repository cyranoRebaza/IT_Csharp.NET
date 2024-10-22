using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Imprimir la suma de los números pares del 1 al 25.
             */

            // declaro las variables
            int numero;
            int suma;

            // inicializo
            numero = 1;
            suma = 0;

            while (numero <= 25)
            {
                // pregunto si el numero es par
                if (numero % 2 == 0)
                {
                    suma += numero; // suma = suma + numero;
                }

                numero++;
            }

            // muestro la suma
            Console.WriteLine($"suma pares: {suma}");
        }
    }
}
