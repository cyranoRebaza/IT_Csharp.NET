using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_EJ08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir la multiplicación de los números impares
             que se encuentran entre -10 y 10.

             */

            // declaracion variables
            int numero;            
            int multiplicador;

            // inicializo
            numero = -10;
            multiplicador = 1;

            while (numero <= 10)
            {
                // busco numero impar
                if (numero % 2 != 0)
                {
                    multiplicador = multiplicador * numero;
                    Console.WriteLine(multiplicador);
                }

                numero++;
            }

             
            
        }
    }
}
