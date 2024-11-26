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
            Realizar un programa que permita ingresar un número entero positivo e informe 
            si es par o  impar. Deberá crear al menos un procedimiento
            y/o una función.
             
             */

            // configurando la apariencia de console
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Uso de un procedimiento";



            // declaracion de variables
            int numeroAr;

            // pido numero
            Console.Write("Ingrese un numero positivo: ");
            numeroAr = Convert.ToInt32(Console.ReadLine());

            // llamo al prodecimiento Par();
            Par(numeroAr);
        }

        // metodo Par()
        static void Par(int numeroPa)
        {
            if (numeroPa % 2 == 0)
            {
                Console.WriteLine("El numero es Par");
            }
            else
            {
                Console.WriteLine("El numero es Impar");
            }
        }

    }
}
