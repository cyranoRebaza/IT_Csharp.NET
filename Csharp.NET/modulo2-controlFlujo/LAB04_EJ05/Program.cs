using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Imprimir los números del 1 al 30 sin imprimir
            números entre el 10 y el 20 uno abajo del otro.

             */

            // declaro variables
            int numero = 1;

            while (numero <= 30)
            {
                if (numero <= 10 || numero >= 20)
                {
                    // muestro numero
                    Console.WriteLine(numero);
                }
                
                numero++;
            }

           

        }
    }
}
