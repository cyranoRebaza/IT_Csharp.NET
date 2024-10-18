using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables e inicializo
            int n1 = 5;
            int n2 = 10;
            int n3 = 20;

            Console.WriteLine($"La suma de {n1} y {n2} es: {n1 + n2}");
            Console.WriteLine("");
            Console.WriteLine($"La resta de {n3} y {n1} es: {n3 + n1}");
            Console.WriteLine("");
            Console.WriteLine($"El producto de {n1} y {n3} es: {n1 * n3}");
            Console.WriteLine("");
            Console.WriteLine($"La division de {n3} y {n2} es: {n3 / n2}");

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
