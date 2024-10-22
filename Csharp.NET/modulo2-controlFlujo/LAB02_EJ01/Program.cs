using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio: dado tres numeros distintos
            int nro1 = 100, nro2 = 500, nro3 = 250;
            
            mostrar cual es el mayor
            */

            //declaro las variables, tipo de dato
            int n1 = 500;
            int n2 = 100;
            int n3 = 250;

            Console.WriteLine($"n1: 500");
            Console.WriteLine($"n2: 100");
            Console.WriteLine($"n3: 250");

            // pregunto si el numero n1 es mayor que n2
            if (n1 > n2)
            {
                // pregunto si n1 es mayor que n3
                if (n1 > n3)
                {
                    Console.WriteLine($"El numero  mayor es {n1}");
                }
                else
                {
                    Console.WriteLine($"El numero  mayor es {n3}");
                }
                
            }
            else
            {
                // preguntos si n2 es mayor que n3
                if (n2 > n3)
                {
                    Console.WriteLine($"El numero mayor es {n2}");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es {n3}");
                }
                            
                               
            }

            
            // metodo 2:

            /*
            if ((n1 > n2) && (n1 > n3))
            {
                Console.WriteLine($"El numero  mayor es {n1}");
            }

            if ((n2 > n1) && (n2 > n3))
            {
                Console.WriteLine($"El numero  mayor es {n2}");
            }

            if ((n3 > n1) && (n3 > n2))
            {
                Console.WriteLine($"El numero  mayor es {n3}");
            }

            */



            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

