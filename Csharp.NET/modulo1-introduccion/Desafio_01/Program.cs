using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Declarar dos variables n1=5 y n2=10.
            Utilizando concatenación entre las variables y los literales, mostrar en pantalla la siguiente
            expresión:
            n1 es igual a 5, n2 es igual a 10 y n1 más n2 es igual a 15.             
             
             */

            Console.WriteLine("\n******* Desafio 1 ********\n");

            //declaro las variables, inicializo
            int n1 = 5;
            int n2 = 10;

            // concatenamos las variables y los literales
            Console.WriteLine($"n1 es igual a {n1}");
            Console.WriteLine($"n2 es igual a {n2}");
            Console.WriteLine($"La suma de n1 y n2 es igual a:  {n1 + n2}");

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
