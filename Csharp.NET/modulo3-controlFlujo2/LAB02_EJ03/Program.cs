using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Implementar un codigo que imprima el mayor y el menor de una serie de cinco
            numero que vamos introduciendo por teclado

             */

            // declaro las variables
            int numero;
            int mayor = 0;
            int menor = 0;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            mayor = numero;
            menor = numero;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > mayor)
                {
                    mayor = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

            }

            Console.WriteLine($"mayor: {mayor}");
            Console.WriteLine($"menor: {menor}");

            
        }
    }
}
