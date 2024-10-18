using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2 - Asignacion Compacta");
            Console.WriteLine("");
            Console.WriteLine("Congina A");

            int x = 10;
            int y = 20;

            Console.WriteLine($"El valor de la varible x es: {x}");
            Console.WriteLine($"El valor de la varible x es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna B ");

            x += 10;
            y -= 15;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es:  {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna C");

            x++;
            y--;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna D");

            x *= 4;
            y *= -3;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");

            Console.WriteLine(".................................");
            Console.WriteLine("Consigna E");

            x /= 2;
            y /= 4;

            Console.WriteLine($"El valor de la variable x es: {x}");
            Console.WriteLine($"El valor de la varible y es: {y}");


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar..");
            Console.ReadKey();
        }
    }
}
