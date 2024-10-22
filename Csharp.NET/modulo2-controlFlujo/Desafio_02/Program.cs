using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo
            informar su suma y diferencia, en caso contrario
            informar el producto y la división del primero respecto al segundo.
             
             */

            // declaracion variables
            int numero1;
            int numero2;
            int suma;
            int diferencia;
            int producto;
            float division;

            // pido los numeros
            Console.Write("Ingrese numero:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese numero:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                suma = numero1 + numero2;
                diferencia = numero1 - numero2;

                Console.WriteLine($"suma: {suma}");
                Console.WriteLine($"diferencia: {diferencia}");
            }
            else
            {
                producto = numero2 * numero1;
                division = (float)numero2 / numero1;

                Console.WriteLine($"producto: {producto}");
                Console.WriteLine($"division: {division}");
            }

            Console.ReadKey();
        }
    }
}
