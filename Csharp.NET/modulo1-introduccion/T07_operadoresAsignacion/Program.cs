using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07_operadoresAsignacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             OPERADORES DE ASIGNACION  
                - (+=, -=, *=, /=)

            OPERADORES INCREMENTO Y DECREMENTO
            - (++) (--)
            
            
             
             */

            // declaro variable
            byte a = 10;

            a += 5; // a = a + 5;

            Console.WriteLine("a: " + a); // a = 15

            a /= 3; // a = a / 3;

            Console.WriteLine("a: " + a); // a = 5

            a++; // a = a + 1;   // a += 1;

            Console.WriteLine("a: " + a); // a = 6

            a--; // a = a - 1;   // a -= 1;

            Console.WriteLine("a: " + a); // a = 5
        }
    }
}
