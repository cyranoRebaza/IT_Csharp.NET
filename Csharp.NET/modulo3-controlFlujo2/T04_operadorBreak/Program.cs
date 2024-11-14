using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_operadorBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejemplo: sumar todos los numeros positivos cortar con un numero negativo -1, cortar la ejecucion si la 
             * sumatoria es mayor a 100
             * */

            int numero;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero positivo o -1 para terminar");
                numero = int.Parse(Console.ReadLine());


                if (numero > 0)
                {
                    suma += numero;
                }

                if (suma > 100)
                {
                    break; // corta y sale de while
                }
            }
            while (numero != -1);

            Console.WriteLine($"suma es: {suma}");

            Console.ReadKey();
        }
    }
}
