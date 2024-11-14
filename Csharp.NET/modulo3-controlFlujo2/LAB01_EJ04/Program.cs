using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir la suma de los numeros impares del 1 al 10
             */
            int sumaImpares = 0;

            for (int i = 1 ; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumaImpares += i;
                }
            }

            Console.WriteLine($"La suma de impares es: {sumaImpares}");
        }
    }
}
