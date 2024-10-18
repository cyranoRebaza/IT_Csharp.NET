using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 1 - Asignacion basica");

            Console.WriteLine("....................");
            Console.WriteLine("Consigna A");
            //declaro las variables,tipo entero, inicializo con un valor
            int x = 10;
            int y = 20;

            Console.WriteLine("El valor de la variable x es :" + x);
            Console.WriteLine("El valor de la variable y es: " + y);

            Console.WriteLine("....................");
            Console.WriteLine("Consigna B");
            x += 5;   // x = x + 5
            y += 10;  // y = y + 10

            Console.WriteLine("El valor de la variable x es :" + x);
            Console.WriteLine("El valor de la variable y es: " + y);

            Console.WriteLine("....................");
            Console.WriteLine("Consigna C");
            x -= 5;   // x = x - 5
            y -= 10;  // x = y - 10

            Console.WriteLine("El valor de la variable x es :" + x);
            Console.WriteLine("El valor de la variable y es: " + y);

            Console.WriteLine("....................");
            Console.WriteLine("Consigna D");

            x *= 3;  // x = x * 3
            y *= 5;  // y = y * 5

            Console.WriteLine("El valor de la variable x es :" + x);
            Console.WriteLine("El valor de la variable y es: " + y);

            Console.WriteLine("....................");
            Console.WriteLine("Consigna E");
            x /= 2;  // x = x / 2
            y /= 4;  // Y = y / 4

            Console.WriteLine("El valor de la variable x es :" + x);
            Console.WriteLine($"El valor de la variable y es: {y} ");


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
