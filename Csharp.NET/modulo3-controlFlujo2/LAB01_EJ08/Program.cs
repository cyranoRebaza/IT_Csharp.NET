using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir la siguiente figura:
            @
            @@
            @@@
            @@@@
            @@@@@
             */

            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("@");
                        break;
                    case 2:
                        Console.WriteLine("@@");
                        break;
                    case 3:
                        Console.WriteLine("@@@");
                        break;
                    case 4:
                        Console.WriteLine("@@@@");
                        break;
                    case 5:
                        Console.WriteLine("@@@@@");
                        break;
                }
            }
            Console.WriteLine("*************************");

            // metodo 2:
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    Console.Write("@");
                }

                Console.WriteLine("@");
            }

            Console.WriteLine("*************************");

            //metodo 3:
            string x = "";
            for (int n = 1; n <= 5; n++)
            {
                x += "@";
                Console.WriteLine(x);
            }
            Console.ReadKey();

        }
    }
}
