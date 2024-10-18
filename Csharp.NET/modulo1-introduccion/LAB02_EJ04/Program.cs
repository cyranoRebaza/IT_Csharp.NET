using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4 - Operadores Aritmeticos con asignacion multiple(producto y division)");
            Console.WriteLine("");

            Console.WriteLine("Consigna A");
            Console.WriteLine("");
            int x = 5;
            int y = 10;
            int multi = 1;
            int division = 1;

            Console.WriteLine($"El valor de x es: {x}");
            Console.WriteLine($"El valor de x es: {y}");
            Console.WriteLine($"El valor de la variable multi es: {multi}");
            Console.WriteLine($"El valor de la variable division es: {division}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna B");
            Console.WriteLine("");

            multi = x * y;
            division = x / y;

            Console.WriteLine($"El valor de x es: {x}");
            Console.WriteLine($"El valor de x es: {y}");
            Console.WriteLine($"El valor de la variable multi es: {multi}");
            Console.WriteLine($"El valor de la variable division es: {division}");


            Console.WriteLine(".................................");
            Console.WriteLine("Consigna C");
            Console.WriteLine("");

            multi = x * x;
            division = y / y;

            Console.WriteLine($"El valor de x es: {x}");
            Console.WriteLine($"El valor de x es: {y}");
            Console.WriteLine($"El valor de la variable multi es: {multi}");
            Console.WriteLine($"El valor de la variable division es: {division}");


            Console.WriteLine(".................................");
            Console.WriteLine("Consigna D");
            Console.WriteLine("");

            multi = x * y * x;
            division = y / x;

            Console.WriteLine($"El valor de x es: {x}");
            Console.WriteLine($"El valor de x es: {y}");
            Console.WriteLine($"El valor de la variable multi es: {multi}");
            Console.WriteLine($"El valor de la variable division es: {division}");


            Console.WriteLine(".................................");
            Console.WriteLine("Consigna E");
            Console.WriteLine("");

            multi = x * (-y);
            division = y / (-x);

            Console.WriteLine($"El valor de x es: {x}");
            Console.WriteLine($"El valor de x es: {y}");
            Console.WriteLine($"El valor de la variable multi es: {multi}");
            Console.WriteLine($"El valor de la variable division es: {division}");

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
