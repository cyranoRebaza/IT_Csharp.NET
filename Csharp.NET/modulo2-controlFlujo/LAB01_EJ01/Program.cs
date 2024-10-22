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
            Console.WriteLine("Ejercicio - condicional ternario");
            Console.WriteLine("Consigna A");
            int n1 = 20;
            int n2 = 10;
            int n3 = (n1 > n2) ? n1 : 0;
            Console.WriteLine(n3);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna B");
            n1 = 20;
            n2 = 10;
            n3 = (n1 < n2) ? n1 : 0;
            Console.WriteLine(n3);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna C");
            n1 = 20;
            n2 = 10;
            n3 = (n1 == n2) ? n1 : 0;
            Console.WriteLine(n3);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna D");
            n1 = 20;
            n2 = 10;
            n3 = (n1 != n2) ? n1 : 0;
            
            Console.WriteLine(n3);

            Console.WriteLine("Presione uan tecla para terminar...");
            Console.ReadKey();

        }
    }
}
