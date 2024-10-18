using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercio 1 - Operadores Aritmeticos");
            Console.WriteLine("");
            Console.WriteLine("Consigna A");

            float x = 10;
            float y = 20;

            Console.WriteLine($"El valor de la  variable x es: {x}");
            Console.WriteLine($"El valor de la  variable x es: {y}");

            Console.WriteLine("...................................");
            Console.WriteLine("Consigna B");

            x += y;  // x = x + y    X = 10 + 20    X=30
            y += x;  // y = y + x    Y = 20 + 30    Y=50

            Console.WriteLine($"El valor de la  variable x es: {x}");
            Console.WriteLine($"El valor de la  variable x es: {y}");

            Console.WriteLine("...................................");
            Console.WriteLine("Consigna C");

            x -= y;  // x = x - y    X = 30 - 50       X=-20
            y -= x;  // y = y - x    Y = 50 - (-20)    Y=70

            Console.WriteLine($"El valor de la  variable x es: {x}");
            Console.WriteLine($"El valor de la  variable x es: {y}");

            Console.WriteLine("...................................");
            Console.WriteLine("Consigna D");

            x *= y;  // x = x * y    X = -20 * 70     X=-1400
            y *= x;  // y = y * x    Y = 70 * (-1400)   Y=-98000

            Console.WriteLine($"El valor de la  variable x es: {x}");
            Console.WriteLine($"El valor de la  variable x es: {y}");

            Console.WriteLine("...................................");
            Console.WriteLine("Consigna E");

            x /= y;  // x = x / y    x = -1400/-98000   x= 0,014 --> uso variables tipo float para mostrarlo
            y /= x;  // y = y / x    y = -98000/0,014285   y=-6,860,343

            Console.WriteLine($"El valor de la  variable x es: {x}");
            Console.WriteLine($"El valor de la  variable y es: {y}");

            Console.WriteLine("Presione una tecla para contunuar...");
            Console.ReadKey();
        }
    }
}
