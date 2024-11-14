using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mostrar numero del 1 al 5 --> con while
            int num = 1; // inicializacion

            while (num <=5) // condicion
            {
                Console.WriteLine(num); // accion
                num++; // postAccion
            }

            Console.WriteLine("***************");

            //mostrar numero del 1 al 5 --> con for
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***************");

            //mostrar 5 asteriscos --> inicializo i = 1
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("*");
            }

            Console.WriteLine("***************");

            //mostrar 5 asteriscos --> inicializo i = 0
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*");
            }


        }
    }
}
