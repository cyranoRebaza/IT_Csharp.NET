using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Dado el siguiente código:
            int a = 10, b=-2, c=5; 
            
            hay 2 números  positivos y 1 negativo.

            Informar la multiplicación de los dos números
            positivos.

             
             */

            // declaro las variables
            int a = 10;
            int b = -2;
            int c = 5;

            if ((a > 0) & (b > 0))
            {
                Console.WriteLine($"a * b = {a * b}");
            }

            if ((a > 0) & (c > 0))
            {
                Console.WriteLine($"a * c = {a * c}");
            }

            if ((b > 0) & (c > 0))
            {
                Console.WriteLine($"b * c = {b * c}");
            }

            Console.ReadKey();

        }
    }
}
