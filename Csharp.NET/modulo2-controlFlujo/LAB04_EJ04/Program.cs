using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir los números del 1 al 10  sin imprimir numeros 2, 5 y 9 uno abajo
             del otro.
             
             */

            // inicializo variable
            int numero = 1;

            while (numero <= 10)
            {
                // muestro numero
                if (numero != 2 && numero != 5 && numero != 9)
                {
                    Console.WriteLine(numero);                    
                }


                // incremento
                numero++;

            }

            Console.ReadKey();
        }
    }
}
