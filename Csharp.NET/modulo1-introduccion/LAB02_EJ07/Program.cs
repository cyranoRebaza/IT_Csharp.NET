using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Logicos");
            Console.WriteLine("");
            Console.WriteLine("Consigna A");
            bool n1 = true;
            bool n2 = false;
            bool n3 = !n1;
            bool n4 = !n2;

            Console.WriteLine($"El valor de la variable n1 es: {n1} ");
            Console.WriteLine($"El valor de la variable n2 es: {n2} ");
            Console.WriteLine($"La negacion de n1 es: {n3}");
            Console.WriteLine($"La negacion de n2 es: {n4}");



            Console.WriteLine("..........");
            Console.WriteLine("Consigna B");
            Console.WriteLine("");
            n3 = n1 & n2;
            n4 = n1 | n2;
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna C");
            Console.WriteLine("");
            n3 = !(n1 & n2);
            n4 = !(n1 | n2);

            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna D");
            Console.WriteLine("");
            n3 = !n1 & n2;
            n4 = !n1 | n2;
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna E");
            Console.WriteLine("");
            n3 = n1 ^ n2;
            n4 = n1 ^ !n2;
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
