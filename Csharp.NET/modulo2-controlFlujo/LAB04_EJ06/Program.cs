using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Imprimir la suma de los números del 1 al 10. 

             */

            // declaracion variables
            int numero;
            int acuSuma;

            // inicializo
            numero = 1;
            acuSuma = 0;

            while (numero <= 10)
            {
                // acumulo
                acuSuma += numero;

                numero++;
            }

            // muestro
            Console.WriteLine($"suma: {acuSuma}");
        }
    }
}
