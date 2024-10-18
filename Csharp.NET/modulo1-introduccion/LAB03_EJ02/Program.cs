using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables e incializo
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            int total;
            float promedio;
            int resto;

            //calculo el total            
            total = n1 + n2 + n3;
            Console.WriteLine($"La suma de {n1} + {n2} + {n3} es: {total} ");
            Console.WriteLine("");

            //calculo el promedio
            promedio = (n1 + n2 + n3) / 3.0f;
            Console.WriteLine($"El promedio  de {n1} + {n2} + {n3} es: {promedio} ");
            Console.WriteLine("");

            //calculo el resto
            resto = n2 % n1;
            Console.WriteLine($"El resto de  {n2} dividido {n1} es: {resto} ");
            Console.WriteLine("");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
