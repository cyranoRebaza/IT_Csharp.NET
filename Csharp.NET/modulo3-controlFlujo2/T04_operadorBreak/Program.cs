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
            /* 
             * Instruccion Break
             * solo se puede incluir dentro de bloques de instrucciones iterativas o swtich
             * corta la ejecucion y continua a partir de otra instruccion
             
             * ******************************************
             * Ejemplo: sumar todos los numeros positivos cortar con un numero negativo -1, cortar la ejecucion si la 
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

            Console.WriteLine("**************************");

            // Ejemplo2:
            for (int i = 2; i <= 30; i+=2)
            {
                Console.WriteLine(i);

                if (i == 20)
                {
                    Console.WriteLine("LLego a 20 y salio con Break");
                    break;
                }

                Console.WriteLine("Aqui salio con el break");
            }

            Console.ReadKey();
        }
    }
}
