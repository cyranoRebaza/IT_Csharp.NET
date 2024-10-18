using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3 - Operadores Aritmeticos con asignacion multiple(suma y resta)");
            Console.WriteLine("");
            Console.WriteLine("Consigna A");
            Console.WriteLine("");


            int x = 5;
            int y = 10;
            int suma = 0;
            int resta = 0;

            Console.WriteLine($"La variable x es: {x}");
            Console.WriteLine($"La variable x es: {y}");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");


            Console.WriteLine(".......................");
            Console.WriteLine("Consigna B");
            Console.WriteLine("");

            suma = x + y;
            resta = x - y;

            Console.WriteLine($"La variable x es: {x}");
            Console.WriteLine($"La variable x es: {y}");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");

            Console.WriteLine(".......................");
            Console.WriteLine("Consigna C");
            Console.WriteLine("");

            suma = x + x;
            resta = y - y;

            Console.WriteLine($"La variable x es: {x}");
            Console.WriteLine($"La variable x es: {y}");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");


            Console.WriteLine(".......................");
            Console.WriteLine("Consigna D");
            Console.WriteLine("");


            suma = x + y + x;
            resta = x - x - 20;

            Console.WriteLine($"La variable x es: {x}");
            Console.WriteLine($"La variable x es: {y}");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");

            Console.WriteLine(".......................");
            Console.WriteLine("Consigna E");
            Console.WriteLine("");


            suma = y + x + x;
            resta = -x - y - y;

            Console.WriteLine($"La variable x es: {x}");
            Console.WriteLine($"La variable x es: {y}");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");



            Console.WriteLine("");
            Console.WriteLine("Presoone una tecla para terminar...");
            Console.ReadKey();

        }
    }
}
