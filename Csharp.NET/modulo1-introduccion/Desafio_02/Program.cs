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
             
            Dadas las variables n1=true, n2=false y n3=true. Informar:

            a. n1 ^ n2
            b. (n1 & !n2) | n3
            c. (n1 | n2) & !n3
                         
             */

            Console.WriteLine("\n******* Desafio 2 ********\n");

            //declaro variables de tipo booleano
            bool n1 = true;
            bool n2 = false;
            bool n3 = true;

            //informo: resultado sera un bool
            Console.WriteLine($"a) {n1} xor {n2} es: {n1 ^ n2}");  //or exclusivo 
            Console.WriteLine($"b) ({n1} & {!n2}) | {n3} es: {(n1 & n2) | n3}  ");
            Console.WriteLine($"c) ({n1} | {n2}) & {!n3} es: {(n1 | n2) & !n3}  ");

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
    }
}
