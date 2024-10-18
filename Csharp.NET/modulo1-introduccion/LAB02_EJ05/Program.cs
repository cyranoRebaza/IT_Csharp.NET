using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5 - Operador Resto");
            Console.WriteLine("");

            Console.WriteLine("Consigna A");
            Console.WriteLine("");
            int n1 = 20;
            int n2 = 2;
            float n3 = n2 % n1;

            Console.WriteLine($"El valor de n1 es: {n1}");
            Console.WriteLine($"El valor de n2 es: {n2}");
            Console.WriteLine($"El valor de n3 es: {n3}");

            Console.WriteLine("........................");
            Console.WriteLine("Consigna B");
            Console.WriteLine("");
            n1 = 15;
            n2 = 2;
            n3 = (n1 % n2);

            Console.WriteLine($"El valor de n1 es: {n1}");
            Console.WriteLine($"El valor de n2 es: {n2}");
            Console.WriteLine($"El valor de n3 es: {n3}");


            Console.WriteLine("........................");
            Console.WriteLine("Consigna C");
            Console.WriteLine("");
            n1 = 3;
            n2 = 20;
            n3 = n2 % n1;

            Console.WriteLine($"El valor de n1 es: {n1}");
            Console.WriteLine($"El valor de n2 es: {n2}");
            Console.WriteLine($"El valor de n3 es: {n3}");


            Console.WriteLine("........................");
            Console.WriteLine("Consigna D");
            Console.WriteLine("");
            n1 = 3;
            n2 = 15;
            n3 = n2 % n1;

            Console.WriteLine($"El valor de n1 es: {n1}");
            Console.WriteLine($"El valor de n2 es: {n2}");
            Console.WriteLine($"El valor de n3 es: {n3}");


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
