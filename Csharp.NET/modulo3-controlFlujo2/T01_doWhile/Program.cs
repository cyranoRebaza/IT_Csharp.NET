using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ESTRUCTURA DO WHILE (ejecuta sentencia luego evalua condicion)

                SINTAXIS:
                do{
                    sentencia;

                }
                while(condicion);
             */

            // Ejemplo: sumar todos los numeros positivos cortar con un numero negativo -1

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
            }
            while (numero != -1);

            Console.WriteLine($"suma es: {suma}");

            Console.ReadKey();

        }
    }
}
