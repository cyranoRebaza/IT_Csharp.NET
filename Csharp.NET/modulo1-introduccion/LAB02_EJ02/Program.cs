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
            Console.WriteLine("Ejercicio 2 - Operadores Aritmeticos con asignacion Compacta");
            Console.WriteLine("");
            Console.WriteLine("Congina A");

            int x = 5;
            int y = 10;

            Console.WriteLine($"El valor de la varible x es: {x}");
            Console.WriteLine($"El valor de la varible x es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna B ");

            x += y;
            y += x;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es:  {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna C");

            x -= y;
            y -= x;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna D");

            x *= y;
            y *= x;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna E");

            x /= y;
            y /= x;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar..");
            Console.ReadKey();
        }
    }
}
