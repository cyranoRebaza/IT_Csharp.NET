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
             Mostrar la suma de los numeros pares mayores a 9 y menores a 20

             */

            // declaro las variables
            int numero = 1;
            int sumaPares = 0;

            // calulo los numero pares que cumplen cierta condicion
            while (numero <= 20)
            {
                if (numero % 2 == 0 && numero > 9 && numero < 20)
                {
                    Console.WriteLine(numero);
                    sumaPares += numero;
                }

                numero++;
            }

            // muestro la suma de numeros pares
            Console.WriteLine($"La suma de los pares es: {sumaPares}");
        }
    }
}
