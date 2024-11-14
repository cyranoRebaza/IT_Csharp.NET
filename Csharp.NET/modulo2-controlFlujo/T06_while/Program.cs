using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ESTRUCTURA WHILE (mientras se cumpla la condicion ejecutara la sentencias asociadas)
                SINTAXIS:
                while(condicion)
                {
                    sentencia;
                }

            bucle infinito:
                - cuando no incremento la variable de la condicion 
                - cuando declaro un variable que tiene un rango limitado
                - cuando incremento la condicion pero esta fuera  de las llaves

             */
            
            
            // mostrar el numero del 1 al 5            
            int n = 1;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);

            Console.WriteLine("*************************");

            // usando estructura while
            int n2 = 1;

            while (n2 <= 5)
            {
                Console.WriteLine(n2);
                n2++;
            }

        }
    }
}
