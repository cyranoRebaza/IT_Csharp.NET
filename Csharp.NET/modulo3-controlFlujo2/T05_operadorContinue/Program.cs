using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_operadorContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejemplo: sumar todos los numeros positivos cortar con un numero negativo -1, cortar la ejecucion si la 
             * sumatoria es mayor a 100 ademas si el numero ingresado es divisible por 3 que no se sume
             * */

            int numero;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero positivo o -1 para terminar");
                numero = int.Parse(Console.ReadLine());

                if (numero % 3 == 0)
                {
                    continue; // saltea lo que viene a continuacion y vuelve al principio del bucle
                }

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
